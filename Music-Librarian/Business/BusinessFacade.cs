using System;
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

		public void LoadDatabase() =>
			throw new NotImplementedException(); //GenresService.Instance.GetAllSkipLyricsExceptions();
	}
}