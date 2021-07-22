using DB;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	
	public class DirectoriesService
	{
		private readonly IDirectoriesRepository _directoriesRepository;

		private DirectoriesService(IDirectoriesRepository directoriesRepository)
		{
			_directoriesRepository = directoriesRepository;
			var allDirectories = _directoriesRepository.GetById(1);
			MusicToDirectory = allDirectories.MusicTo;
		}
		
		internal string MusicToDirectory { get; set; }
		public static DirectoriesService Instance { get; } = new(new DirectoriesRepository(Database.GetContext()));
		

		public void SaveChanges()
		{
			var directories = _directoriesRepository.GetById(1);
			directories.MusicTo = MusicToDirectory;
			_directoriesRepository.SaveChanges();
		}
	}
}