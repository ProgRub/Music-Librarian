using System;
using System.Collections.Generic;
using DB.Entities;

namespace DB.Repositories.Interfaces
{
	public interface IWorkoutRepository : IGenericRepository<Workout>
	{
		void AddTimeToWorkoutById(int workoutId,  DateTime dateTime);
	}
}