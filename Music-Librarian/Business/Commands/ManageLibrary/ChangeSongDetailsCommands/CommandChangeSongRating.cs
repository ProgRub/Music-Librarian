using Business.DTOs;
using Business.Services;
using DB.Entities;
using DB.Migrations;
using System.Diagnostics;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongRating : IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;

		private Song _songInDB;
		private readonly int _newRating;
		private int _oldRating;

		File IChangeSongDetailsCommand.SongFile
		{
			get => _songFile;
			set => _songFile = value;
		}

		SongDTO IChangeSongDetailsCommand.Song
		{
			get => _song;
			set => _song = value;
		}

		public CommandChangeSongRating(int newRating)
		{
			_newRating = newRating;
		}

		public void Execute()
		{
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_oldRating = _song.Rating;
			SongService.Instance.MusicService.ChangeRating(_song, _newRating);
			_song.Rating = _newRating;
			_songInDB.Rating = _newRating;

			Debug.WriteLine($"Original:{_oldRating} New:{_newRating}");
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeRating(_song, _oldRating);
			_song.Rating = _oldRating;
			_songInDB.Rating = _oldRating;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeRating(_song, _newRating);
			_song.Rating = _newRating;
			_songInDB.Rating = _newRating;
		}
	}
}