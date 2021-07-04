using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class DirectoriesRepository : GenericRepository<Directories>, IDirectoriesRepository
	{
		public DirectoriesRepository(DatabaseContext context) : base(context)
		{
		}
	}
}