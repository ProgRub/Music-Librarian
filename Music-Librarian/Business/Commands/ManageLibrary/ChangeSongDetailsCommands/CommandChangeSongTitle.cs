using Business.DTOs;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongTitle:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private Song _songInDB;
		private string _oldSongTitle, _newSongTitle;

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

		public CommandChangeSongTitle(string newSongTitle)
		{
			_newSongTitle = newSongTitle;
		}

		public void Execute()
		{
			_oldSongTitle = _song.Title;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			BusinessFacade.Instance.MusicService.ChangeSongTitle(_song,_newSongTitle);
			_songFile.Tag.Title = _newSongTitle;
			_songInDB.Title = _newSongTitle;
			_song.Title = _newSongTitle;
		}

		public void Undo()
		{
			BusinessFacade.Instance.MusicService.ChangeSongTitle(_song,_oldSongTitle);
			_songFile.Tag.Title = _oldSongTitle;
			_songInDB.Title = _oldSongTitle;
			_song.Title = _oldSongTitle;
		}

		public void Redo()
		{
			BusinessFacade.Instance.MusicService.ChangeSongTitle(_song,_newSongTitle);
			_songFile.Tag.Title = _newSongTitle;
			_songInDB.Title = _newSongTitle;
			_song.Title = _newSongTitle;
		}
	}
}