using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Business.CustomEventArgs;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using Business.Services.MusicServices;

namespace Business
{
	public class BusinessFacade
	{
		public event EventHandler<UpdatePlayCountEventArgs> NotifyUpdatePlayCounts;
		internal IMusicService MusicService { get; }
		private BusinessFacade()
		{
			AlbumService.Instance.GetAlbumsFromDatabase();
			MusicService = iTunesService.Instance;
			MusicService.OpenService();
			SongService.Instance.MusicService = MusicService;
			SongService.Instance.NotifyUpdatePlayCounts +=
				(sender, args) => NotifyUpdatePlayCounts.Invoke(sender, args);
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

		public void UpdateDatabasePlayCounts()
		{
			SongService.Instance.UpdateAllPlayCounts();
		}

		public void SetMusicServicePlayCountsBasedOnDatabase()
		{
			SongService.Instance.SetAllMusicServicePlayCounts();
		}

		public void SetSongToEditLyrics(SongDTO song) => SongService.Instance.SongToChangeLyrics = song;

		public SongDTO GetSongToEditLyrics() => SongService.Instance.SongToChangeLyrics;

		public IEnumerable<WorkoutDTO> GetAllWorkouts() => WorkoutService.Instance.GetWorkouts();

		public void SetSelectedWorkout(WorkoutDTO selectedWorkout) => WorkoutService.Instance.SelectedWorkout = selectedWorkout;

		public TimeSpan GetAverageCompletionTimeOfSelectedWorkout() => WorkoutService.Instance.GetAverageCompletionTimeOfSelectedWorkout();

		public TimeSpan GetMaximumLeewayOfSelectedWorkout() =>
			WorkoutService.Instance.GetMaximumLeewayOfSelectedWorkout();
	}
}