using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
	public class YearLyricsChangeDetailsExceptionRepository : GenericRepository<YearLyricsChangeDetailsException>,
		IYearLyricsChangeDetailsExceptionRepository
	{
		public YearLyricsChangeDetailsExceptionRepository(DatabaseContext context) : base(context)
		{
		}
	}
}