using System;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongPlayCount:IChangeSongDetailsCommand
	{
		private SongDTO _song;
		private Song _songInDB;
		private int _oldPlayCount, _newPlayCount;
		private readonly int _playCountChange;
		private readonly IntegerSongDetailsChangeType _changeType;

		File IChangeSongDetailsCommand.SongFile { get; set; }

		SongDTO IChangeSongDetailsCommand.Song
		{
			get => _song;
			set => _song = value;
		}

		public CommandChangeSongPlayCount(IntegerSongDetailsChangeType changeType, int playCountChange)
		{
			_playCountChange = playCountChange;
			_changeType = changeType;
		}

		public void Execute()
		{
			_oldPlayCount = _song.PlayCount;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_newPlayCount = _changeType switch
			{
				IntegerSongDetailsChangeType.Add => _oldPlayCount + _playCountChange,
				IntegerSongDetailsChangeType.Subtract => _oldPlayCount - _playCountChange,
				IntegerSongDetailsChangeType.Set => _playCountChange,
				_ => throw new ArgumentOutOfRangeException()
			};
			SongService.Instance.MusicService.ChangePlayCount(_song,_newPlayCount);
			_songInDB.PlayCount = _newPlayCount;
			_song.PlayCount = _newPlayCount;
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangePlayCount(_song,_oldPlayCount);
			_songInDB.PlayCount = _oldPlayCount;
			_song.PlayCount = _oldPlayCount;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangePlayCount(_song,_newPlayCount);
			_songInDB.PlayCount = _newPlayCount;
			_song.PlayCount = _newPlayCount;
		}
	}
}