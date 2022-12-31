using System;
using System.Collections.Generic;
using System.IO;
using DB.Entities;

namespace Business.DTOs
{
	public class SongDTO
	{
		public int Id { get; init; }
		public string Filename { get; set; }
		public string AlbumArtist { get; set; }
		public IEnumerable<string> ContributingArtists { get; set; }
		public string Album { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }
		public int TrackNumber { get; set; }
		public int DiscNumber { get; set; }
		public int Year { get; set; }
		public int PlayCount { get; set; }
		public int Rating { get; set; }
		public string Lyrics { get; set; }
		public DateTime LastModified { get; private init; }
		public TimeSpan Duration { get; private init; }

		public static SongDTO ConvertSongToDTO(Song song)
		{
			return new()
			{
				Id=song.Id,
				Filename = song.Filename,
				Album = song.Album.Title,
				AlbumArtist = song.AlbumArtist,
				ContributingArtists = song.ContributingArtists,
				DiscNumber = song.DiscNumber,
				TrackNumber = song.TrackNumber,
				Title = song.Title,
				Genre = song.Genre.Name,
				Year = song.Year,
				Rating=song.Rating,
				Lyrics = song.Lyrics,
				LastModified = File.GetLastWriteTime(song.Filename),
				Duration = song.Duration, PlayCount = song.PlayCount
			};
		}
	}
}