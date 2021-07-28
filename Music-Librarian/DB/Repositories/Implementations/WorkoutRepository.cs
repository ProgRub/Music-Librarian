using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
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
			workout.WorkoutDateTimes.Add(DateTime.Today.Date.Add(time));
			using var context=Database.GetContext();
			context.Update(workout);
			context.SaveChanges();
		}

	}
}