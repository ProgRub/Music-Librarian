using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Business.DTOs;
using iTunesLib;

namespace Business.Services.MusicServices
{
	public class iTunesService : IMusicService
	{
		private iTunesService()
		{
		}

		private iTunesApp _iTunes;
		private IITLibraryPlaylist _iTunesLibrary;

		public static IMusicService Instance { get; } = new iTunesService();

		public void AddSong(SongDTO song)
		{
			var operationStatus =
				_iTunesLibrary.AddFile(Path.Combine(DirectoriesService.Instance.MusicToDirectory, song.Filename));
			while (operationStatus.InProgress)
			{
			}

			var addedTrack = operationStatus.Tracks[1];
			if (song.Year < 1985)
			{
				addedTrack.VolumeAdjustment = 50;
			}
		}

		public void DeleteSong(SongDTO song)
		{
			GetTrack(song.Title, song.Album).Delete();
		}

		public void ChangeAlbumArtist(SongDTO song, string newAlbumArtist)
		{
			GetTrack(song.Title, song.Album).AlbumArtist = newAlbumArtist;
		}

		public void ChangeContributingArtists(SongDTO song, IEnumerable<string> newContributingArtists)
		{
			GetTrack(song.Title, song.Album).Artist = string.Join(';', newContributingArtists);
		}

		public void ChangeAlbum(SongDTO song, string newAlbum)
		{
			GetTrack(song.Title, song.Album).Album = newAlbum;
		}

		public void ChangeGenre(SongDTO song, string newGenre)
		{
			GetTrack(song.Title, song.Album).Genre = newGenre;
		}

		public void ChangeSongTitle(SongDTO song, string newSongTitle)
		{
			GetTrack(song.Title, song.Album).Name = newSongTitle;
		}

		public void ChangeYear(SongDTO song, int newYear)
		{
			GetTrack(song.Title, song.Album).Year = newYear;
		}

		public void ChangeTrackNumber(SongDTO song, int newTrackNumber)
		{
			GetTrack(song.Title, song.Album).TrackNumber = newTrackNumber;
		}

		public void ChangeDiscNumber(SongDTO song, int newDiscNumber)
		{
			GetTrack(song.Title, song.Album).DiscNumber = newDiscNumber;
		}

		public void ChangeRating(SongDTO song, int newRating)
		{
			GetTrack(song.Title,song.Album).Rating = newRating*20;
		}

		public void ChangeSongLyrics(SongDTO song, string newLyrics)
		{
			GetTrack(song.Title, song.Album).Lyrics = newLyrics;
		}
		public void ChangePlayCount(SongDTO song, int newPlayCount)
		{
			GetTrack(song.Title, song.Album).PlayedCount = newPlayCount;
		}

		public int GetPlayCountOfSong(SongDTO song)
		{
			return GetTrack(song.Title, song.Album).PlayedCount;
		}
		public IITFileOrCDTrack GetTrack(string title, string album)
		{
			if (_iTunes == null)
			{
				OpenService();
			}

			IITTrackCollection tracks;
			while (true)
			{
				try
				{
					tracks = _iTunesLibrary.Search(title, ITPlaylistSearchField.ITPlaylistSearchFieldSongNames);
					break;
				}
				catch (Exception)
				{
					Debug.WriteLine("NO PLAYLIST");
					_iTunesLibrary = _iTunes.LibraryPlaylist;
				}
			}
			if (tracks == null) return null;
			for (var index = 1; index <= tracks.Count; index++)
			{
				if (tracks[index].Album == album)
				{
					return (IITFileOrCDTrack) tracks[index];
				}
			}

			return null;
		}

		public void OpenService()
		{
			if (_iTunes != null) return;
			_iTunes = new iTunesApp();
			_iTunesLibrary = _iTunes.LibraryPlaylist;
		}

		public void OpenAlbum(AlbumDTO albumDto)
		{
			var song = albumDto.Songs.OrderBy(song => song.DiscNumber).ThenBy(song => song.TrackNumber).First();
			((IITFileOrCDTrack) GetTrack(song.Title, song.Album)).Reveal();
		}

		public void EndLink()
		{
			if (_iTunes == null) return;
			System.Runtime.InteropServices.Marshal.ReleaseComObject(_iTunes);
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}