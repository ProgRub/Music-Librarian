using System.Collections.Generic;

namespace Business.DTOs
{
    public class AlbumDTO
    {
        public int Id { get; }
        public string Title { get; }
        public string Artist { get; }
        public string Genre { get; }
        public IEnumerable<SongDTO>Songs { get; }
        public int TotalTrackCount { get; }
        public int TotalDiscCount { get; }
        public int Year { get; }
    }
}