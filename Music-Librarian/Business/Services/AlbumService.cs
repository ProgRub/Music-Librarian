using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Business.DTOs;
using Business.Enums;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	public class AlbumService
	{
		private IAlbumRepository _albumRepository;

		private AlbumService()
		{
			_albumRepository = new AlbumRepository(Database.GetContext());
			GetAlbumsFromDatabase();
		}
		internal static AlbumService Instance { get; } = new();
		internal TimeSpan AlbumTime { get; set; }
		internal TimeSpan Leeway { get; set; }
		internal ISet<Genre> SelectedGenres { get; } = new HashSet<Genre>();
		internal LeewayType LeewayType { get; set; }
		internal ISet<AlbumDTO> Albums { get; set; }

		internal void ClearSelectedGenres() => SelectedGenres.Clear();

		private void GetAlbumsFromDatabase()
		{
			Albums = _albumRepository.GetAll().Select(AlbumDTO.ConvertAlbumToDTO).ToHashSet();
		}

	}
}