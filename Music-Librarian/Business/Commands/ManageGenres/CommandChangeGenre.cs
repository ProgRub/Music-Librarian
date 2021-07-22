using System.Collections.Generic;
using System.Drawing;
using Business.DTOs;
using Business.Services;
using DB.Entities;

namespace Business.Commands.ManageGenres
{
	public class CommandChangeGenre : ICommand
	{
		private readonly Genre _genre;
		private readonly GenreDTO _genreDto;
		private readonly string _oldName;
		private readonly string _newName;
		private readonly Color _oldColor;
		private readonly Color _newColor;
		private readonly IList<GenreDTO> _genres;

		public CommandChangeGenre(GenreDTO selectedGenre, string newName, Color newColor,
			ref IList<GenreDTO> genres)
		{
			_genreDto = selectedGenre;
			_genre = GenresService.Instance.GetGenreById(_genreDto.Id);
			_oldName = _genre.Name;
			_oldColor = _genre.Color;
			_newName = newName;
			_newColor = newColor;
			_genres = genres;
		}

		public void Execute()
		{
			_genre.Name = _newName;
			_genre.Color = _newColor;
			_genreDto.Name = _newName;
			_genreDto.Color = _newColor;
			for (var index = 0; index < _genres.Count; index++)
			{
				if (_genres[index].Id == _genreDto.Id) _genres[index] = _genreDto;
			}
		}

		public void Undo()
		{
			_genre.Name = _oldName;
			_genre.Color = _oldColor;
			_genreDto.Name = _oldName;
			_genreDto.Color = _oldColor;
			for (var index = 0; index < _genres.Count; index++)
			{
				if (_genres[index].Id == _genreDto.Id) _genres[index] = _genreDto;
			}
		}

		public void Redo() => Execute();
	}
}