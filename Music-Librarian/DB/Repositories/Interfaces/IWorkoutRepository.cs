﻿using System;
using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface IWorkoutRepository : IGenericRepository<Workout>
	{
		void AddTimeToWorkoutById(int workoutId, TimeSpan time);
	}
}