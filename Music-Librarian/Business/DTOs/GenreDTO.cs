using System.Drawing;
using DB.Entities;

namespace Business.DTOs
{
	public class GenreDTO
	{
		public int Id { get; init; }
		public string Name { get; set; }
		public Color Color { get; set; }

		internal static GenreDTO ConvertGenreToDTO(Genre genre)
		{
			return new()
			{
				Id=genre.Id,Name = genre.Name,Color = genre.Color
			};
		}
	}
}