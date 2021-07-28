using System;
using System.Collections.Generic;
using Business.Services;
using DB.Entities;

namespace Business
{
	public class WorkoutDTO
	{
		public int Id { get; private init; }
		public string Name { get; set; }
		public IEnumerable<DateTime> WorkoutDateTimes { get;private init; }

		internal static WorkoutDTO ConvertWorkoutToDTO(Workout workout)
		{
			return new()
			{
				Id = workout.Id, Name = workout.Name, WorkoutDateTimes =workout.WorkoutDateTimes
			};
		}
	}
}