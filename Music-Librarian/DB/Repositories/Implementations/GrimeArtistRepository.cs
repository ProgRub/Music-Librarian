using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class GrimeArtistRepository : GenericRepository<GrimeArtist>, IGrimeArtistRepository
	{
		public GrimeArtistRepository(DatabaseContext context) : base(context)
		{
		}
	}
}