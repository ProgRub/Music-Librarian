using System.Collections.Generic;
using System.IO;
using Business.DTOs;
using Business.Services;
using File = TagLib.File;

namespace Business.Commands.ManageLibrary
{
	public class MacroCommandChangeSongsDetails : ICommand
	{
		private readonly List<IChangeSongDetailsCommand> _commands = new();
		private readonly ISet<SongDTO> _songs;

		public MacroCommandChangeSongsDetails(ISet<SongDTO> songs)
		{
			_songs = songs;
		}

		public void Add(IChangeSongDetailsCommand command)
		{
			_commands.Add(command);
		}

		public void Execute()
		{
			foreach (var song in _songs)
			{
				using var mp3File=File.Create(Path.Combine(DirectoriesService.Instance.MusicToDirectory,song.Filename));
				foreach (var command in _commands)
				{
					command.SongFile = mp3File;
					command.Execute();
				}
				mp3File.Save();
			}
		}

		public void Undo()
		{
			_commands.Reverse();
			foreach (var song in _songs)
			{
				foreach (var command in _commands)
				{
					command.Undo();
					command.SongFile.Save();
				}
			}

			_commands.Reverse();
		}

		public void Redo()
		{
			foreach (var song in _songs)
			{
				foreach (var command in _commands)
				{
					command.Redo();
					command.SongFile.Save();
				}
			}
		}
	}
}