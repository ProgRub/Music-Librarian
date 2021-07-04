using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
	{
		public ArtistRepository(DatabaseContext context) : base(context)
		{
		}
	}
}