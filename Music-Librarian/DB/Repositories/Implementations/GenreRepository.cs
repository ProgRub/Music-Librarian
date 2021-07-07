using System.Drawing;
using System.Linq;
using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class GenreRepository : GenericRepository<Genre>, IGenreRepository
	{
		public GenreRepository(DatabaseContext context) : base(context)
		{
		}

		public Genre GetGenreOrCreateNewOne(string name)
		{
			var genres = Find(e => e.Name == name).ToList();

			if (genres.Any()) return genres.First();
			var genre = new Genre {Name = name, Argb = Color.White.ToArgb()};
			Add(genre);
			SaveChanges();
			return genre;
		}
	}
}