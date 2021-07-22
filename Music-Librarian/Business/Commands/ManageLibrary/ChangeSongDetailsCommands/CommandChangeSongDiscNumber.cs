using System;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongDiscNumber : IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private Song _songInDB;
		private int _oldDiscNumber, _newDiscNumber;
		private readonly int _discNumberChange;
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

		public CommandChangeSongDiscNumber(IntegerSongDetailsChangeType changeType, int discNumberChange)
		{
			_discNumberChange = discNumberChange;
			_changeType = changeType;
		}

		public void Execute()
		{
			_oldDiscNumber = _song.DiscNumber;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_newDiscNumber = _changeType switch
			{
				IntegerSongDetailsChangeType.Add => _oldDiscNumber + _discNumberChange,
				IntegerSongDetailsChangeType.Subtract => _oldDiscNumber - _discNumberChange,
				IntegerSongDetailsChangeType.Set => _discNumberChange,
				_ => throw new ArgumentOutOfRangeException()
			};
			SongService.Instance.MusicService.ChangeDiscNumber(_song, _newDiscNumber);
			_songFile.Tag.Disc = (uint) _newDiscNumber;
			_songInDB.DiscNumber = _newDiscNumber;
			_song.DiscNumber = _newDiscNumber;
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeDiscNumber(_song, _oldDiscNumber);
			_songFile.Tag.Disc = (uint) _oldDiscNumber;
			_songInDB.DiscNumber = _oldDiscNumber;
			_song.DiscNumber = _oldDiscNumber;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeDiscNumber(_song, _newDiscNumber);
			_songFile.Tag.Disc = (uint) _newDiscNumber;
			_songInDB.DiscNumber = _newDiscNumber;
			_song.DiscNumber = _newDiscNumber;
		}
	}
}