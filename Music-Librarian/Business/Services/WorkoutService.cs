using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	public class WorkoutService
	{
		private IWorkoutRepository _workoutRepository;

		private WorkoutService()
		{
			_workoutRepository = new WorkoutRepository(Database.GetContext());
		}

		public static WorkoutService Instance { get; } = new();

		internal WorkoutDTO SelectedWorkout { get; set; }

		internal IEnumerable<WorkoutDTO> GetWorkouts()
		{
			return _workoutRepository.GetAll().Select(WorkoutDTO.ConvertWorkoutToDTO);
		}

		internal TimeSpan GetAverageCompletionTimeOfSelectedWorkout()
		{
			return TimeSpan.FromSeconds(SelectedWorkout.WorkoutDateTimes.Select(e => e.TimeOfDay.TotalSeconds).Average());
		}

		public TimeSpan GetMaximumLeewayOfSelectedWorkout()
		{
			var selectedWorkoutTimes = SelectedWorkout.WorkoutDateTimes.Select(e=>e.TimeOfDay);
			var minimum = selectedWorkoutTimes.Min();
			var maximum = selectedWorkoutTimes.Max();
			var average = GetAverageCompletionTimeOfSelectedWorkout();
			var differenceBetweenMaxAndAverage = maximum-average;
			var differenceBetweenMinAndAverage = average-minimum;
			return differenceBetweenMaxAndAverage >
			       differenceBetweenMinAndAverage ? differenceBetweenMaxAndAverage : differenceBetweenMinAndAverage;
		}
		
	}
}