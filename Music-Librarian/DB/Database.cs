namespace DB
{
	public static class Database
	{
		public static DatabaseContext GetContext()
		{
			return new();
		}
	}
}