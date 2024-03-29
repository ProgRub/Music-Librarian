﻿using System.IO;
using Business.DTOs;
using Business.Services;

namespace Business.Commands.ManageLibrary
{
	public class CommandChangeFilename : ICommand
	{
		private readonly SongDTO _song;
		private readonly string _oldFilePath;
		private readonly string _newFilePath;
		private readonly string _newFilename;
		private readonly string _oldFilename;

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