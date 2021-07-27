using System;
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

		public void Add(Song song, string albumTitle, string genreName, int totalTrackCount, int totalDiscCount,DateTime lastModifiedDateTime)
		{
			var genre = _genreRepository.GetGenreOrCreateNewOne(genreName);
			var album = _albumRepository.GetAlbumOrCreateNewOne(albumTitle, genre, song, totalTrackCount,
				totalDiscCount);
			song.Album =
				album;
			album.Songs.Add(song);
			song.Genre = genre;
			song.LastModified=lastModifiedDateTime;
			Add(song);
		}

		public void ChangeAlbum(Song song, string albumTitle,  int totalTrackCount, int totalDiscCount)
		{
			var oldAlbum = song.Album;
			song.Album = _albumRepository.GetAlbumOrCreateNewOne(albumTitle, song.Genre, song, totalTrackCount, totalDiscCount);
			song.Album.Songs.Add(song);
			SaveChanges();
			oldAlbum.Songs.Remove(song);
			if (oldAlbum.Songs.Count == 0)
			{
				_albumRepository.Remove(oldAlbum);
			}
		}

		public void ChangeGenre(Song song, string genreName)
		{
			var newGenre = _genreRepository.GetGenreOrCreateNewOne(genreName);
			var oldGenre = song.Genre;
			song.Genre = newGenre;
			if (!Find(e => e.Genre == oldGenre).Any())
			{
				_genreRepository.Remove(oldGenre);
			}

			SaveChanges();

			var album = song.Album;
			var albumGenreGroups=album.Songs.GroupBy(song => song.GenreId, song=>song,
				(genreId, songs) => new {Key = genreId, Count = songs.Count()});
			albumGenreGroups=albumGenreGroups.OrderByDescending(e => e.Count);
			song.Album.GenreId = albumGenreGroups.First().Key;
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
			if (album.Songs.Count ==0)
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