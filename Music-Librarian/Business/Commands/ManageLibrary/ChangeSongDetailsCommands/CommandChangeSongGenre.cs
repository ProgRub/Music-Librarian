using Business.DTOs;
using Business.Services;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongGenre:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private readonly string _newGenreName;
		private string _oldGenreName;

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

		public CommandChangeSongGenre(string newGenreName)
		{
			_newGenreName = newGenreName;
		}

		public void Execute()
		{
			_oldGenreName = _song.Genre;
			SongService.Instance.MusicService.ChangeGenre(_song,_newGenreName);
			SongService.Instance.ChangeSongGenre(_song, _newGenreName);
			_song.Genre = _newGenreName;
			_songFile.Tag.Genres = new[] {_newGenreName};
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeGenre(_song,_oldGenreName);
			SongService.Instance.ChangeSongGenre(_song, _oldGenreName);
			_song.Genre = _oldGenreName;
			_songFile.Tag.Genres = new[] {_oldGenreName};
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeGenre(_song,_newGenreName);
			SongService.Instance.ChangeSongGenre(_song, _newGenreName);
			_song.Genre = _newGenreName;
			_songFile.Tag.Genres = new[] {_newGenreName};
		}
	}
}