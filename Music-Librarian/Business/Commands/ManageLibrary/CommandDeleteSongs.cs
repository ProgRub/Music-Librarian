using System;
using System.Collections.Generic;
using Business.DTOs;
using Business.Services;

namespace Business.Commands.ManageLibrary
{
	public class CommandDeleteSongs : ICommand
	{
		private ISet<SongDTO> _songs;
		public CommandDeleteSongs(ISet<SongDTO> songs)
		{
			_songs = songs;
		}

		public void Execute() => SongService.Instance.MarkSongsToDelete(_songs);

		public void Undo() => SongService.Instance.UnMarkSongsToDelete(_songs);

		public void Redo() => Execute();
	}
}