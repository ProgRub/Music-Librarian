using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class UrlReplacementRepository : GenericRepository<UrlReplacement>, IUrlReplacementRepository
    {
        public UrlReplacementRepository(DatabaseContext context) : base(context)
        {
        }
    }
}