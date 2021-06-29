using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class SongHasContributingArtistsRepository : GenericRepository<SongHasContributingArtists>,ISongHasContributingArtistsRepository
    {
        public SongHasContributingArtistsRepository(DatabaseContext context) : base(context)
        {
        }
    }
}