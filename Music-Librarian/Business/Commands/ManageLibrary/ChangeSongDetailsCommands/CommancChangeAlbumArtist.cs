﻿using Business.DTOs;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeAlbumArtist:IChangeSongDetailsCommand
	{
		private File _songFile;
		private readonly string _newAlbumArtist;
		private string _oldAlbumArtist;
		private SongDTO _song;
		private Song _songInDB;

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
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_songFile.Tag.AlbumArtists = new[] {_newAlbumArtist};
			_song.AlbumArtist = _newAlbumArtist;
			_songInDB.AlbumArtist = _newAlbumArtist;
			_songInDB.Album.Artist = _newAlbumArtist;
			BusinessFacade.Instance.MusicService.ChangeAlbumArtist(_song,_newAlbumArtist);
		}

		public void Undo()
		{
			_songFile.Tag.AlbumArtists = new[] {_oldAlbumArtist};
			_song.AlbumArtist = _oldAlbumArtist;
			_songInDB.AlbumArtist = _oldAlbumArtist;
			_songInDB.Album.Artist = _oldAlbumArtist;
			BusinessFacade.Instance.MusicService.ChangeAlbumArtist(_song,_oldAlbumArtist);
		}

		public void Redo()
		{
			_songFile.Tag.AlbumArtists = new[] {_newAlbumArtist};
			_song.AlbumArtist = _newAlbumArtist;
			_songInDB.AlbumArtist = _newAlbumArtist;
			_songInDB.Album.Artist = _newAlbumArtist;
			BusinessFacade.Instance.MusicService.ChangeAlbumArtist(_song,_newAlbumArtist);
		}
	}
}