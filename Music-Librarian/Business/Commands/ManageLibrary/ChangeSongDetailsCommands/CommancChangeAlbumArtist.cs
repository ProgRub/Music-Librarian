using Business.DTOs;
using iTunesLib;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeAlbumArtist:IChangeSongDetailsCommand
	{
		private File _songFile;
		private readonly string _newAlbumArtist;
		private string _oldAlbumArtist;
		private SongDTO _song;

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

		public CommandChangeAlbumArtist(string newAlbumArtist)
		{
			_newAlbumArtist = newAlbumArtist;
		}

		public void Execute()
		{
			_oldAlbumArtist = _songFile.Tag.FirstAlbumArtist;
			_songFile.Tag.AlbumArtists = new[] {_newAlbumArtist};
			_song.AlbumArtist = _newAlbumArtist;
			BusinessFacade.Instance.MusicService.ChangeAlbumArtist(_song,_newAlbumArtist);
		}

		public void Undo()
		{
			_songFile.Tag.AlbumArtists = new[] {_oldAlbumArtist};
			_song.AlbumArtist = _oldAlbumArtist;
			BusinessFacade.Instance.MusicService.ChangeAlbumArtist(_song,_oldAlbumArtist);
		}

		public void Redo() => Execute();
	}
}