using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	internal class GenresService
	{
		private readonly IGenreRepository _genreRepository;

		private GenresService()
		{
			_genreRepository = new GenreRepository(Database.GetContext());
		}

		internal static GenresService Instance { get; } = new();

		internal IEnumerable<GenreDTO> GetAllGenres() => _genreRepository.GetAll().Select(GenreDTO.ConvertGenreToDTO);
		internal void SaveChanges() => _genreRepository.SaveChanges();

		public Genre GetGenreById(int id) => _genreRepository.GetById(id);
	}
}