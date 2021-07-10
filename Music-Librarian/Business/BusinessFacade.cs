using System;
using System.Collections.Generic;
using Business.DTOs;
using Business.Services;

namespace Business
{
	public class BusinessFacade
	{
		private BusinessFacade()
		{
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
	}
}