using System.Collections.Generic;

namespace Business.DTOs
{
    public class SongDTO
    {

        public int Id { get; }
        public string Filename { get; set; }
        public string AlbumArtist { get; set; }
        public IEnumerable<string> ContributingArtists { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int TrackNumber { get; set; }
        public int DiscNumber { get; set; }
        public int Year { get; set; }
        public int PlayCount { get; set; }
    }
}