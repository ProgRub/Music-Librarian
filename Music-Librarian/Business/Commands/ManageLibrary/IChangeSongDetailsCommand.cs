using Business.DTOs;

namespace Business.Commands.ManageLibrary
{
	public interface IChangeSongDetailsCommand:ICommand
	{
		internal TagLib.File SongFile { get; set; }
		internal SongDTO Song { get; set; }
	}
}