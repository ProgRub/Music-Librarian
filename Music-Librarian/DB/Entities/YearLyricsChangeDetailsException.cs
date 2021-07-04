namespace DB.Entities
{
	public class YearLyricsChangeDetailsException
	{
		public int Id { get; set; }
		public ChangeDetailsExceptionType Type { get; set; }
		public string OriginalArtist { get; set; }
		public string OriginalAlbum { get; set; }
		public string OriginalTitle { get; set; }
		public string NewArtist { get; set; }
		public string NewAlbum { get; set; }
		public string NewTitle { get; set; }
	}

	public enum ChangeDetailsExceptionType
	{
		ChangeDetailsForAlbumYear,
		ChangeDetailsForLyrics,
		SkipAlbumYear,
		SkipLyrics
	}
}