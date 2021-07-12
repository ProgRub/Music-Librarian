using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using Business.Services.MusicServices;

namespace Business
{
	public class BusinessFacade
	{
		internal IMusicService MusicService { get; }
		private BusinessFacade()
		{
			AlbumService.Instance.GetAlbumsFromDatabase();
			MusicService = iTunesService.Instance;
			SongService.Instance.MusicService = MusicService;
			MusicService.OpenService();
			SongService.Instance.UpdateAllPlayCounts();
		}

		public static BusinessFacade Instance { get; } = new();

		public void SetMusicLibraryDirectory(string musicToDirectory) =>
			DirectoriesService.Instance.MusicToDirectory = musicToDirectory;

		public string GetMusicLibraryDirectory() => DirectoriesService.Instance.MusicToDirectory;

		public void LoadDatabase() =>GenresService.Instance.GetAllGenres();

		public IEnumerable<GenreDTO> GetAllGenres() => GenresService.Instance.GetAllGenres();

		public void SaveChanges()
		{
			foreach (var thread in SongService.Instance.Threads)
			{
				thread.Join();
			}
			GenresService.Instance.SaveChanges();
			DirectoriesService.Instance.SaveChanges();
			SongService.Instance.SaveChanges();
			AlbumService.Instance.SaveChanges();
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

		public MemoryStream GetAlbumArtworkMemoryStream(SongDTO song) =>
			SongService.Instance.GetAlbumArtworkMemoryStream(song);

		public void OpenAlbumOnService(AlbumDTO album) => MusicService.OpenAlbum(album);

		public void EndServiceLink()
		{
			MusicService.EndLink();
		}

		public IEnumerable<SongDTO> GetAllSongs() => SongService.Instance.AllSongs;
	}
}