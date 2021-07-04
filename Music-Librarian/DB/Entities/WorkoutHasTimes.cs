namespace DB.Entities
{
	public class WorkoutHasTimes
	{
		public int WorkoutId;
		public Workout Workout;
		public int WorkoutTimeId;
		public WorkoutTime WorkoutTime;
	}
}