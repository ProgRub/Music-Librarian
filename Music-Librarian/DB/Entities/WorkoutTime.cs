using System;
using System.Collections.Generic;

namespace DB.Entities
{
	public class WorkoutTime
	{
		public int Id { get; set; }
		public DateTime DateAndDuration { get; set; }
		public virtual ICollection<WorkoutHasTimes> WorkoutHasTimesCollection { get; set; }
	}
}