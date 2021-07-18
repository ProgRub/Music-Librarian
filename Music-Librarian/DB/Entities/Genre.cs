using System.Drawing;

namespace DB.Entities
{
	public class Genre
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int Argb
		{
			get => fColor.ToArgb();
			set => fColor = Color.FromArgb(value);
		}

		private Color fColor;

		public Color Color
		{
			get => fColor;
			set => fColor = value;
		}
	}
}