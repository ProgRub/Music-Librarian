namespace DB.Entities
{
    public class YearLyricsChangeDetailsException
    {
        public int Id { get; set; }
        public ExceptionType Type { get; set; }
        public string OriginalArtist { get; set; }
        public string OriginalAlbum { get; set; }
        public string OriginalTitle { get; set; }
        public string NewArtist { get; set; }
        public string NewAlbum { get; set; }
        public string NewTitle { get; set; }
    }
    public enum ExceptionType{ChangeDetailsForYear,ChangeDetailsForLyrics,SkipYear,SkipLyrics}
}