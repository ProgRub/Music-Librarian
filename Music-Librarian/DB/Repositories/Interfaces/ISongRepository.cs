using System;
using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface ISongRepository : IGenericRepository<Song>
	{
		void Add(Song song, string albumTitle, string genreName, int totalTrackCount, int totalDiscCount,DateTime lastModifiedDateTime);
		void ChangeGenre(Song song, string genreName);
		void ChangeAlbum(Song song, string albumTitle, int totalTrackCount, int totalDiscCount);
		void RemoveSingle(Song song);
	}
}