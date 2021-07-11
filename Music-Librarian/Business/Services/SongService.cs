using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using Business.DTOs;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;
using iTunesLib;

namespace Business.Services
{
	public class SongService
	{
		private ISongRepository _songRepository;

		private SongService()
		{
			_songRepository = new SongRepository(Database.GetContext());
		}

		internal static SongService Instance { get; } = new();

		internal void SaveChanges() => _songRepository.SaveChanges();

		internal MemoryStream GetAlbumArtworkMemoryStream(SongDTO song)
		{
			using var mp3 = TagLib.File.Create(Path.Combine(DirectoriesService.Instance.MusicToDirectory, song.Filename));
			return new MemoryStream((byte[])(mp3.Tag.Pictures[0].Data.Data));
		}
	}
}