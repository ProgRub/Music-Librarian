using System.Collections.Generic;
using Business.DTOs;

namespace Business.Services.MusicServices
{
	public interface IMusicService
	{
		void AddSong(SongDTO song);
		void DeleteSong(SongDTO song);
		void ChangePlayCount(SongDTO song, int newPlayCount);
		void ChangeAlbumArtist(SongDTO song, string newAlbumArtist);
		void ChangeContributingArtists(SongDTO song, IEnumerable<string> newContributingArtists);
		void ChangeAlbum(SongDTO song,string newAlbum);
		void ChangeGenre(SongDTO song, string newGenre);
		void ChangeSongTitle(SongDTO song, string newSongTitle);
		void ChangeYear(SongDTO song, int newYear);
		void ChangeTrackNumber(SongDTO song, int newTrackNumber);
		void ChangeDiscNumber(SongDTO song, int newDiscNumber);
		int GetPlayCountOfSong(SongDTO song);
		void OpenService();
		void OpenAlbum(AlbumDTO albumDto);
		void EndLink();
		void ChangeSongLyrics(SongDTO song, string newLyrics);
	}
}