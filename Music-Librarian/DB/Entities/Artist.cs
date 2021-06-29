using System.Collections.Generic;

namespace DB.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SongHasContributingArtists> SongHasContributingArtistsCollection { get; set; }
    }
}