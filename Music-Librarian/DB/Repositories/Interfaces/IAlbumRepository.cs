using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface IAlbumRepository : IGenericRepository<Album>
	{
		Album GetAlbumOrCreateNewOne(string albumTitle, Genre genre, Song song, int totalTrackCount,
			int totalDiscCount);
	}
}