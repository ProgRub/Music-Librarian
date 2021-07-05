using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface ISongRepository : IGenericRepository<Song>
	{
		void Add(Song song, string albumTitle, string genreName, int totalTrackCount, int totalDiscCount);
		void RemoveSingle(Song song);
	}
}