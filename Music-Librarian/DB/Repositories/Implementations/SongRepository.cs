using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class SongRepository : GenericRepository<Song>, ISongRepository
	{
		public SongRepository(DatabaseContext context) : base(context)
		{
		}
	}
}