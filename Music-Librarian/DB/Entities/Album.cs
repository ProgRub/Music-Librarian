using System.Collections.Generic;

namespace DB.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int TotalTrackCount { get; set; }
        public int TotalDiscCount { get; set; }
        public int Year { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}