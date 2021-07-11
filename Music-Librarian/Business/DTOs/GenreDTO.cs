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

		protected bool Equals(GenreDTO other)
		{
			return Name == other.Name;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((GenreDTO) obj);
		}

		public override int GetHashCode()
		{
			return (Name != null ? Name.GetHashCode() : 0);
		}

		public static bool operator ==(GenreDTO left, GenreDTO right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(GenreDTO left, GenreDTO right)
		{
			return !Equals(left, right);
		}
	}
}