using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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
		private readonly IAlbumRepository _albumRepository;

		private AlbumService()
		{
			_albumRepository = new AlbumRepository(Database.GetContext());
		}
		internal static AlbumService Instance { get; } = new();
		internal TimeSpan AlbumTime { get; set; }
		internal TimeSpan Leeway { get; set; }
		internal ISet<Genre> SelectedGenres { get; } = new HashSet<Genre>();
		internal LeewayType LeewayType { get; set; }
		internal ISet<AlbumDTO> Albums { get; set; }

		internal void ClearSelectedGenres() => SelectedGenres.Clear();

		internal void GetAlbumsFromDatabase() => new Thread(()=>Albums = _albumRepository.GetAll().Select(AlbumDTO.ConvertAlbumToDTO).ToHashSet()).Start();
	}
}