using System;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongTrackNumber:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private Song _songInDB;
		private int _oldTrackNumber, _newTrackNumber;
		private readonly int _trackNumberChange;
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

		public CommandChangeSongTrackNumber(IntegerSongDetailsChangeType changeType, int trackNumberChange)
		{
			_trackNumberChange = trackNumberChange;
			_changeType = changeType;
		}

		public void Execute()
		{
			_oldTrackNumber = _song.TrackNumber;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_newTrackNumber = _changeType switch
			{
				IntegerSongDetailsChangeType.Add => _oldTrackNumber + _trackNumberChange,
				IntegerSongDetailsChangeType.Subtract => _oldTrackNumber - _trackNumberChange,
				IntegerSongDetailsChangeType.Set => _trackNumberChange,
				_ => throw new ArgumentOutOfRangeException()
			};
			SongService.Instance.MusicService.ChangeTrackNumber(_song,_newTrackNumber);
			_songFile.Tag.Track = (uint) _newTrackNumber;
			_songInDB.TrackNumber = _newTrackNumber;
			_song.TrackNumber = _newTrackNumber;
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeTrackNumber(_song,_oldTrackNumber);
			_songFile.Tag.Track = (uint) _oldTrackNumber;
			_songInDB.TrackNumber = _oldTrackNumber;
			_song.TrackNumber = _oldTrackNumber;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeTrackNumber(_song,_newTrackNumber);
			_songFile.Tag.Track = (uint) _newTrackNumber;
			_songInDB.TrackNumber = _newTrackNumber;
			_song.TrackNumber = _newTrackNumber;
		}
	}
}