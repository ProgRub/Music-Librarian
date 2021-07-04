namespace DB.Entities
{
	public class SongHasContributingArtists
	{
		public int SongId { get; set; }
		public Song Song { get; set; }
		public int ArtistId { get; set; }
		public Artist Artist { get; set; }
	}
}