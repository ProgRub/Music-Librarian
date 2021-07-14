using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Business.CustomEventArgs;
using Business.DTOs;
using Business.Services.MusicServices;
using DB;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;
using File = TagLib.File;

namespace Business.Services
{
	public class SongService
	{
		private ISongRepository _songRepository;
		private static readonly int _numberOfThreads = (int) Math.Pow(2, (int) Math.Sqrt(Environment.ProcessorCount));
		internal ICollection<Thread> Threads { get; } = new List<Thread>();
		internal IMusicService MusicService { get; set; }
		internal event EventHandler<UpdatePlayCountEventArgs> NotifyUpdatePlayCounts;

		private SongService()
		{
			_songRepository = new SongRepository(Database.GetContext());
			AllSongs = _songRepository.GetAll().Select(SongDTO.ConvertSongToDTO).ToHashSet();
		}

		internal static SongService Instance { get; } = new();
		internal ISet<SongDTO> AllSongs { get; }

		internal void SaveChanges()
		{
			foreach (var song in AllSongs)
			{
				_songRepository.Find(e => e.Filename == song.Filename).First().PlayCount = song.PlayCount;
			}

			_songRepository.SaveChanges();
		}

		internal MemoryStream GetAlbumArtworkMemoryStream(SongDTO song)
		{
			using var mp3 =
				File.Create(Path.Combine(DirectoriesService.Instance.MusicToDirectory, song.Filename));
			return new MemoryStream(mp3.Tag.Pictures[0].Data.Data);
		}

		internal void UpdateAllPlayCounts()
		{
			var totalNumberOfSongs = AllSongs.Count;
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
				thread.Start(AllSongs.Skip(previousFiles).Take(filesPerThreadList[index]).ToHashSet());
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

		public void SetAllMusicServicePlayCounts()
		{
			var totalNumberOfSongs = AllSongs.Count;
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
				thread.Start(AllSongs.Skip(previousFiles).Take(filesPerThreadList[index]).ToHashSet());
			}
		}

		private void SetMusicServicePlayCountsSectionOfSongs(object parameter)
		{
			var songsSection = (HashSet<SongDTO>) parameter;
			foreach (var song in songsSection)
			{
				var oldPlayCount = MusicService.GetPlayCountOfSong(song);
				MusicService.GetTrack(song.Title, song.Album).PlayedCount = song.PlayCount;
				NotifyUpdatePlayCounts?.Invoke(this,
					new UpdatePlayCountEventArgs
						{Song = song, OldPlayCount = oldPlayCount, NewPlayCount = song.PlayCount});
			}
		}
	}
}