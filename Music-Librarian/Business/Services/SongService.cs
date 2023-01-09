using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Business.CustomEventArgs;
using Business.DTOs;
using Business.Services.MusicServices;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;
using Microsoft.VisualBasic.FileIO;

namespace Business.Services
{
	internal class SongService
	{
		private readonly ISongRepository _songRepository;
		private static readonly int _numberOfThreads = (int) Math.Pow(2, (int) Math.Sqrt(Environment.ProcessorCount));
		internal ICollection<Thread> Threads { get; } = new List<Thread>();
		internal IMusicService MusicService { get; set; }
		internal event EventHandler<UpdatePlayCountEventArgs> NotifyUpdatePlayCounts;
		private readonly ISet<SongDTO> _songsToDelete = new HashSet<SongDTO>();
		private readonly IDictionary<SongDTO, string> _songsAlbumChanges = new Dictionary<SongDTO, string>();
		private readonly IDictionary<SongDTO, string> _songsGenreChanges = new Dictionary<SongDTO, string>();
		private bool _needToUpdateDatabasePlayCounts;

		private SongService()
		{
			_needToUpdateDatabasePlayCounts = false;
			_songRepository = new SongRepository(Database.GetContext());
		}

		internal static SongService Instance { get; } = new();
		internal SongDTO SongToChangeLyrics { get; set; }
		private int _songCount;

		internal HashSet<SongDTO> GetAllSongs()
		{
			var allSongs = _songRepository.GetAll().Select(SongDTO.ConvertSongToDTO).ToHashSet();
			_songCount = allSongs.Count;
			return allSongs;
		}

		internal Song GetSongById(int id) => _songRepository.GetById(id);

		internal int GetTotalSongs() => _songCount;

		internal void SaveChanges()
		{
			var musicToDirectory = DirectoriesService.Instance.MusicToDirectory;
			foreach (var songToDelete in _songsToDelete)
			{
				_songRepository.Remove(_songRepository.GetById(songToDelete.Id));
				try
				{
					MusicService.DeleteSong(songToDelete);
				}
				catch (Exception)
				{
					// ignored
				}

				var filePath = Path.Combine(musicToDirectory, songToDelete.Filename);
				if (File.Exists(filePath))
					FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs,
						RecycleOption.SendToRecycleBin);
			}

			foreach (var (song, albumTitle) in _songsAlbumChanges)
			{
				var songInDB = _songRepository.GetById(song.Id);
				if (songInDB.Album.Title == albumTitle) continue;
				_songRepository.ChangeAlbum(songInDB,albumTitle,songInDB.Album.TotalTrackCount,songInDB.Album.TotalDiscCount);
			}

			foreach (var (song, genreName) in _songsGenreChanges)
			{
				var songInDB = _songRepository.GetById(song.Id);
				if (songInDB.Genre.Name == genreName) continue;
				_songRepository.ChangeGenre(songInDB,genreName);
			}

			if(_needToUpdateDatabasePlayCounts)
			{
				foreach (var song in GetAllSongs())
				{
					_songRepository.Find(e => e.Filename == song.Filename).First().PlayCount = song.PlayCount;
				}
			}

			_songRepository.SaveChanges();
		}

		internal MemoryStream GetAlbumArtworkMemoryStream(SongDTO song)
		{
			using var mp3 =
				TagLib.File.Create(Path.Combine(DirectoriesService.Instance.MusicToDirectory, song.Filename));
			return new MemoryStream(mp3.Tag.Pictures[0].Data.Data);
		}

		internal void UpdateAllPlayCounts()
		{
			_needToUpdateDatabasePlayCounts = true;
			var allSongs = GetAllSongs();
			var totalNumberOfSongs = _songCount;
			var rest = totalNumberOfSongs % _numberOfThreads;
			var result = totalNumberOfSongs / (double) _numberOfThreads;
			var filesPerThreadList = new List<int>();
			for (var i = 0; i < _numberOfThreads; i++)
			{
				if (rest-- > 0)
					filesPerThreadList.Add((int) Math.Ceiling(result));
				else
					filesPerThreadList.Add((int) Math.Floor(result));
			}

			var previousFiles = 0;
			for (var index = 0; index < _numberOfThreads; index++)
			{
				var thread = new Thread(UpdatePlayCountsSectionOfSongs)
				{
					IsBackground = true
				};
				if (index != 0)
				{
					previousFiles += filesPerThreadList[index - 1];
				}

				thread.Priority = ThreadPriority.Highest;
				Threads.Add(thread);
				thread.Start(allSongs.Skip(previousFiles).Take(filesPerThreadList[index]).ToHashSet());
			}
		}

		private void UpdatePlayCountsSectionOfSongs(object parameter)
		{
			var songsSection = (HashSet<SongDTO>) parameter;
			foreach (var song in songsSection)
			{
				var oldPlayCount = song.PlayCount;
				song.PlayCount = MusicService.GetPlayCountOfSong(song);
				NotifyUpdatePlayCounts?.Invoke(this,
					new UpdatePlayCountEventArgs
						{Song = song, OldPlayCount = oldPlayCount, NewPlayCount = song.PlayCount});
			}
		}

		internal void SetAllMusicServicePlayCounts()
		{
			_needToUpdateDatabasePlayCounts = true;
			var allSongs = GetAllSongs();
			var totalNumberOfSongs = _songCount;
			var rest = totalNumberOfSongs % _numberOfThreads;
			var result = totalNumberOfSongs / (double) _numberOfThreads;
			var filesPerThreadList = new List<int>();
			for (var i = 0; i < _numberOfThreads; i++)
			{
				if (rest-- > 0)
					filesPerThreadList.Add((int) Math.Ceiling(result));
				else
					filesPerThreadList.Add((int) Math.Floor(result));
			}

			var previousFiles = 0;
			for (var index = 0; index < _numberOfThreads; index++)
			{
				var thread = new Thread(SetMusicServicePlayCountsSectionOfSongs)
				{
					IsBackground = true
				};
				if (index != 0)
				{
					previousFiles += filesPerThreadList[index - 1];
				}

				thread.Priority = ThreadPriority.Highest;
				Threads.Add(thread);
				thread.Start(allSongs.Skip(previousFiles).Take(filesPerThreadList[index]).ToHashSet());
			}
		}

		private void SetMusicServicePlayCountsSectionOfSongs(object parameter)
		{
			var songsSection = (HashSet<SongDTO>) parameter;
			foreach (var song in songsSection)
			{
				var oldPlayCount = MusicService.GetPlayCountOfSong(song);
				MusicService.ChangePlayCount(song, song.PlayCount);
				NotifyUpdatePlayCounts?.Invoke(this,
					new UpdatePlayCountEventArgs
						{Song = song, OldPlayCount = oldPlayCount, NewPlayCount = song.PlayCount});
			}
		}

		internal void MarkSongsToDelete(ISet<SongDTO> songs)
		{
			foreach (var song in songs)
			{
				_songsToDelete.Add(song);
			}
		}

		internal void UnMarkSongsToDelete(ISet<SongDTO> songs)
		{
			foreach (var song in songs)
			{
				_songsToDelete.Remove(song);
			}
		}

		internal void SetLastModifiedTime(SongDTO song)
		{
			_songRepository.GetById(song.Id).LastModified = File.GetLastWriteTime(Path.Combine(DirectoriesService.Instance.MusicToDirectory,song.Filename));
		}

		internal void ChangeSongAlbum(SongDTO song, string newAlbum)
		{
			_songsAlbumChanges[song] = newAlbum;
		}

		internal void ChangeSongGenre(SongDTO song, string newGenre)
		{
			_songsGenreChanges[song] = newGenre;
		}
	}
}