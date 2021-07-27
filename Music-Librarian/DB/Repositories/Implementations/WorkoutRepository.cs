using System;
using System.Data;
using DB.Entities;
using DB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories.Implementations
{
	public class WorkoutRepository : GenericRepository<Workout>, IWorkoutRepository
	{
		public WorkoutRepository(DatabaseContext context) : base(context)
		{
		}

		public void AddTimeToWorkoutById(int workoutId, TimeSpan time)
		{
			var workout = GetById(workoutId);
			var workoutDateTimes = workout.WorkoutDateTimes;
			workoutDateTimes.Add(DateTime.Today.Date.Add(time));
			workout.WorkoutDateTimes=workoutDateTimes;
			SaveChanges();
		}

	}
}