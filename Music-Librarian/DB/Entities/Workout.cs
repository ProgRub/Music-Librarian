using System;
using System.Collections.Generic;

namespace DB.Entities
{
	public class Workout
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public HashSet<DateTime> WorkoutDateTimes { get; set; }
	}
}