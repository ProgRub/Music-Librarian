using Business.DTOs;
using DB.Entities;
using iTunesLib;

namespace Business.Services.MusicServices
{
	public interface IMusicService
	{
		void AddSong(SongDTO song);
		void DeleteSong(SongDTO song);
		int GetPlayCountOfSong(SongDTO song);
		IITTrack GetTrack(string title, string album);
		void OpenService();
		void OpenAlbum(AlbumDTO albumDto);
		void EndLink();
	}
}