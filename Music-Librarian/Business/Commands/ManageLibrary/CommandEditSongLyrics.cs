using Business.DTOs;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary
{
	public class CommandEditSongLyrics:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private Song _songInDB;
		private string _oldLyrics, _newLyrics;

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

		public CommandEditSongLyrics(string newLyrics)
		{
			_newLyrics = newLyrics;
		}

		public void Execute()
		{
			_oldLyrics = _song.Lyrics;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			BusinessFacade.Instance.MusicService.ChangeSongLyrics(_song,_newLyrics);
			_songFile.Tag.Lyrics = _newLyrics;
			_songInDB.Lyrics = _newLyrics;
			_song.Lyrics = _newLyrics;
		}

		public void Undo()
		{
			BusinessFacade.Instance.MusicService.ChangeSongLyrics(_song,_oldLyrics);
			_songFile.Tag.Lyrics = _oldLyrics;
			_songInDB.Lyrics = _oldLyrics;
			_song.Lyrics = _oldLyrics;
		}

		public void Redo()
		{
			BusinessFacade.Instance.MusicService.ChangeSongLyrics(_song,_newLyrics);
			_songFile.Tag.Lyrics = _newLyrics;
			_songInDB.Lyrics = _newLyrics;
			_song.Lyrics = _newLyrics;
		}
	}
}