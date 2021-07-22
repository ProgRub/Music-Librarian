using Business.DTOs;
using Business.Services;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeSongAlbum:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private readonly string _newAlbumTitle;
		private string _oldAlbumTitle;

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

		public CommandChangeSongAlbum(string newAlbumTitle)
		{
			_newAlbumTitle = newAlbumTitle;
		}

		public void Execute()
		{
			_oldAlbumTitle = _song.Album;
			SongService.Instance.MusicService.ChangeAlbum(_song,_newAlbumTitle);
			SongService.Instance.ChangeSongAlbum(_song, _newAlbumTitle);
			_song.Album = _newAlbumTitle;
			_songFile.Tag.Album = _newAlbumTitle;
		}

		public void Undo()
		{
			SongService.Instance.MusicService.ChangeAlbum(_song,_oldAlbumTitle);
			SongService.Instance.ChangeSongAlbum(_song, _oldAlbumTitle);
			_song.Album = _oldAlbumTitle;
			_songFile.Tag.Album = _oldAlbumTitle;
		}

		public void Redo()
		{
			SongService.Instance.MusicService.ChangeAlbum(_song,_newAlbumTitle);
			SongService.Instance.ChangeSongAlbum(_song, _newAlbumTitle);
			_song.Album = _newAlbumTitle;
			_songFile.Tag.Album = _newAlbumTitle;
		}
	}
}