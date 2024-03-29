﻿using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface IGenreRepository : IGenericRepository<Genre>
	{
		Genre GetGenreOrCreateNewOne(string name);
	}
}