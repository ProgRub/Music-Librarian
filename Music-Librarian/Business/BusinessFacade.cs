using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Business.DTOs;
using Business.Enums;
using Business.Services;

namespace Business
{
	public class BusinessFacade
	{
		private BusinessFacade()
		{
			AlbumService.Instance.GetAlbumsFromDatabase();
		}

		public static BusinessFacade Instance { get; } = new();

		public void SetMusicLibraryDirectory(string musicToDirectory) =>
			DirectoriesService.Instance.MusicToDirectory = musicToDirectory;

		public string GetMusicLibraryDirectory() => DirectoriesService.Instance.MusicToDirectory;

		public void LoadDatabase() =>GenresService.Instance.GetAllGenres();

		public IEnumerable<GenreDTO> GetAllGenres() => GenresService.Instance.GetAllGenres();

		public void SaveChanges()
		{
			GenresService.Instance.SaveChanges();
			DirectoriesService.Instance.SaveChanges();
		}

		public void SetLeewayType(LeewayType type)
		{
			AlbumService.Instance.LeewayType = type;
			Debug.WriteLine(AlbumService.Instance.LeewayType);
		}

		public void SetAlbumProperties(TimeSpan albumTime, TimeSpan leeway)
		{
			AlbumService.Instance.AlbumTime = albumTime;
			AlbumService.Instance.Leeway = leeway;
			Debug.WriteLine(AlbumService.Instance.AlbumTime);
			Debug.WriteLine(AlbumService.Instance.Leeway);
		}

		public void SetSelectedGenres(IEnumerable<GenreDTO> selectedGenres)
		{
			AlbumService.Instance.SelectedGenres = selectedGenres.ToHashSet();
		}

		public IEnumerable<AlbumDTO> GetPossibleAlbums() => AlbumService.Instance.GetPossibleAlbums();

		public TimeSpan GetMinimumAlbumTime() => AlbumService.Instance.MinimumAlbumTime;

		public TimeSpan GetMaximumAlbumTime() => AlbumService.Instance.MaximumAlbumTime;

		public void SetSelectedAlbum(AlbumDTO selectedAlbum) => AlbumService.Instance.SelectedAlbum = selectedAlbum;
		public AlbumDTO GetSelectedAlbum() => AlbumService.Instance.SelectedAlbum;
	}
}