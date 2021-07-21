using System;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongYear:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private Song _songInDB;
		private int _oldYear, _newYear;
		private readonly int _yearChange;
		private readonly IntegerSongDetailsChangeType _changeType;

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

		public CommandChangeSongYear(IntegerSongDetailsChangeType changeType, int yearChange)
		{
			_yearChange = yearChange;
			_changeType = changeType;
		}

		public void Execute()
		{
			_oldYear = _song.Year;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_newYear = _changeType switch
			{
				IntegerSongDetailsChangeType.Add => _oldYear + _yearChange,
				IntegerSongDetailsChangeType.Subtract => _oldYear - _yearChange,
				IntegerSongDetailsChangeType.Set => _yearChange,
				_ => throw new ArgumentOutOfRangeException()
			};
			SongService.Instance.MusicService.ChangeYear(_song,_newYear);
			_songFile.Tag.Year = (uint) _newYear;
			_songInDB.Year = _newYear;
			_song.Year = _newYear;
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeYear(_song,_oldYear);
			_songFile.Tag.Year = (uint) _oldYear;
			_songInDB.Year = _oldYear;
			_song.Year = _oldYear;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeYear(_song,_newYear);
			_songFile.Tag.Year = (uint) _newYear;
			_songInDB.Year = _newYear;
			_song.Year = _newYear;
		}
	}
}