using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Business.DTOs;
using Business.Enums;
using DB;
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
		internal TimeSpan MinimumAlbumTime { get; set; }
		internal TimeSpan MaximumAlbumTime { get; set; }
		internal ISet<GenreDTO> SelectedGenres { get; set; }
		internal LeewayType LeewayType { get; set; }
		internal ISet<AlbumDTO> Albums { get; set; }
		internal AlbumDTO SelectedAlbum { get; set; }

		internal void GetAlbumsFromDatabase() => new Thread(()=>Albums = _albumRepository.GetAll().Select(AlbumDTO.ConvertAlbumToDTO).ToHashSet()).Start();

		internal IEnumerable<AlbumDTO> GetPossibleAlbums()
		{
			MinimumAlbumTime = LeewayType != LeewayType.Over ? AlbumTime - Leeway : AlbumTime;
			MaximumAlbumTime = LeewayType != LeewayType.Under ? AlbumTime + Leeway : AlbumTime;
			return Albums.Where(album=>album.Duration>= MinimumAlbumTime && album.Duration <= MaximumAlbumTime &&SelectedGenres.Contains(album.Genre));
		}

		internal void SaveChanges() => _albumRepository.SaveChanges();
	}
}