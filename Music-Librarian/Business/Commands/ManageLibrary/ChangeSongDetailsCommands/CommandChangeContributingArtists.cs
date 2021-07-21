using System;
using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using Business.Services;
using DB.Entities;
using TagLib;

namespace Business.Commands.ManageLibrary.ChangeSongDetailsCommands
{
	public class CommandChangeContributingArtists:IChangeSongDetailsCommand
	{
		private File _songFile;
		private SongDTO _song;
		private IList<string> _oldContributingArtists;
		private readonly IList<string> _newContributingArtists;
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

		public CommandChangeContributingArtists(string newContributingArtists)
		{
			_newContributingArtists = newContributingArtists.Split(';', StringSplitOptions.RemoveEmptyEntries);
		}

		public void Execute()
		{
			_oldContributingArtists = _songFile.Tag.Performers;
			_songInDB = SongService.Instance.GetSongById(_song.Id);
			_songFile.Tag.Performers = _newContributingArtists.ToArray();
			_song.ContributingArtists = _newContributingArtists;
			_songInDB.ContributingArtists = _newContributingArtists;
			BusinessFacade.Instance.MusicService.ChangeContributingArtists(_song,_newContributingArtists);
		}

		public void Undo()
		{
			_songFile.Tag.Performers = _oldContributingArtists.ToArray();
			_song.ContributingArtists = _oldContributingArtists;
			_songInDB.ContributingArtists = _oldContributingArtists;
			BusinessFacade.Instance.MusicService.ChangeContributingArtists(_song,_oldContributingArtists);
		}

		public void Redo()
		{
			_songFile.Tag.Performers = _newContributingArtists.ToArray();
			_song.ContributingArtists = _newContributingArtists;
			_songInDB.ContributingArtists = _newContributingArtists;
			BusinessFacade.Instance.MusicService.ChangeContributingArtists(_song,_newContributingArtists);
		}
	}
}