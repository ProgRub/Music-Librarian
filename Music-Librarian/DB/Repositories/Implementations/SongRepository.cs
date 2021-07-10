using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class SongRepository : GenericRepository<Song>, ISongRepository
	{
		private readonly IAlbumRepository _albumRepository;
		private readonly IGenreRepository _genreRepository;

		public SongRepository(DatabaseContext context) : base(context)
		{
			_albumRepository = new AlbumRepository(context);
			_genreRepository = new GenreRepository(context);
		}

		public void Add(Song song, string albumTitle, string genreName, int totalTrackCount, int totalDiscCount)
		{
			var genre = _genreRepository.GetGenreOrCreateNewOne(genreName);
			var album = _albumRepository.GetAlbumOrCreateNewOne(albumTitle, genre, song, totalTrackCount,
				totalDiscCount);
			song.Album =
				album;
			album.Songs.Add(song);
			song.Genre = genre;
			Add(song);
		}

		public new void Remove(Song song)
		{
			var genre = song.Genre;
			if (!Find(e => e.Genre == genre).Any())
			{
				_genreRepository.Remove(genre);
			}

			var album = song.Album;
			album.Songs.Remove(song);
			if (album.Songs.Count <= 1)
			{
				_albumRepository.Remove(album);
			}

			base.Remove(song);
		}

		public void RemoveSingle(Song song)
		{
			Remove(song);
			SaveChanges();
		}
	}
}