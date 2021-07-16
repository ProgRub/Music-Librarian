using System;
using System.IO;
using Business.DTOs;
using Business.Services;
using DB.Entities;

namespace Business.Commands.ManageLibrary
{
	public class CommandChangeFilename : ICommand
	{
		private SongDTO _song;
		private string _oldFilePath, _newFilePath,_newFilename,_oldFilename;
		public CommandChangeFilename(SongDTO song, string newFilename)
		{
			_song = song;
			_newFilename = newFilename;
			_oldFilename = song.Filename;
			_newFilePath =Path.Combine(DirectoriesService.Instance.MusicToDirectory, _newFilename);
			_oldFilePath = Path.Combine(DirectoriesService.Instance.MusicToDirectory, _oldFilename);
		}

		public void Execute()
		{
			_song.Filename = _newFilename;
			File.Move(_oldFilePath,_newFilePath);
		}

		public void Undo()
		{
			_song.Filename = _oldFilename;
			File.Move(_newFilePath,_oldFilePath);
		}

		public void Redo() => Execute();
	}
}