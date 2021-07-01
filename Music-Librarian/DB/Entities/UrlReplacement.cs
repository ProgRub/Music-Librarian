namespace DB.Entities
{
    public class UrlReplacement
    {
        public int Id { get; set; }
        public string StringToReplace { get; set; }
        public string StringReplacement { get; set; }
    }
}