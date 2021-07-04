using System.IO;

namespace DB.Entities
{
	public class Directories
	{
		public int Id { get; set; }
		public string MusicFrom { get; set; }
		public string MusicTo { get; set; }
		public string UniFrom { get; set; }
		public string UniToBaseDirectory { get; set; }
	}
}