using System;
using System.Collections.Generic;
using System.Linq;
using DB.Entities;

namespace Business.DTOs
{
	public class AlbumDTO
	{
		public int Id { get; init; }
		public string Title { get; set; }
		public string Artist { get; set; }
		public GenreDTO Genre { get; set; }
		public IEnumerable<SongDTO> Songs { get; set; }
		public int TotalTrackCount { get; set; }
		public int TotalDiscCount { get; set; }
		public int Year { get; set; }
		public TimeSpan Duration { get; set; }
		public double AveragePlayCount { get; set; }

		internal static AlbumDTO ConvertAlbumToDTO(Album album)
		{
			AlbumDTO albumDto = new()
			{
				Id = album.Id, Title = album.Title, Artist = album.Artist, Genre = GenreDTO.ConvertGenreToDTO(album.Genre),
				TotalTrackCount = album.TotalTrackCount, TotalDiscCount = album.TotalDiscCount, Year = album.Year,
				Songs = album.Songs.Select(SongDTO.ConvertSongToDTO)
			};
			foreach (var song in albumDto.Songs)
			{
				albumDto.Duration += song.Duration;
			}

			albumDto.AveragePlayCount = albumDto.Songs.Average(song => song.PlayCount);
			return albumDto;
		}

		public override string ToString()
		{
			return $"{Artist} - {Title} | {Duration}";
		}
	}
}