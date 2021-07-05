using System.Collections.Generic;
using System.Linq;
using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
	{
		public AlbumRepository(DatabaseContext context) : base(context)
		{
		}

		public Album GetAlbumOrCreateNewOne(string albumTitle,Genre genre,Song song,int totalTrackCount,int totalDiscCount)
		{
			var albums = Find(e => e.Title == albumTitle).ToList();
			if (albums.Any()) return albums.First();
			var album = new Album
			{
				Genre = genre, Artist = song.AlbumArtist, Title = albumTitle, TotalDiscCount = totalDiscCount,
				TotalTrackCount = totalTrackCount, Year = song.Year, Songs = new List<Song> {}
			};
			Add(album);
			SaveChanges();
			return album;
		}
	}
}