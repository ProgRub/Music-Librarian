using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class UniFileFormatRepositoryRepository : GenericRepository<UniFileFormat>,IUniFileFormatRepository
    {
        public UniFileFormatRepositoryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}