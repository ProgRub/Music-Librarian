using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class AlbumRepository:GenericRepository<Album>,IAlbumRepository
    {
        public AlbumRepository(DatabaseContext context) : base(context)
        {
        }
    }
}