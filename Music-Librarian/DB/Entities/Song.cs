using System.Collections.Generic;

namespace DB.Entities
{
	public class Song
	{
		public int Id { get; set; }
		public string Filename { get; set; }
		public string AlbumArtist { get; set; }
		public ICollection<string> ContributingArtists { get; set; }
		public int AlbumId { get; set; }
		public Album Album { get; set; }
		public string Title { get; set; }
		public int GenreId { get; set; }
		public Genre Genre { get; set; }
		public int TrackNumber { get; set; }
		public int DiscNumber { get; set; }
		public int Year { get; set; }
		public int PlayCount { get; set; }
	}
}