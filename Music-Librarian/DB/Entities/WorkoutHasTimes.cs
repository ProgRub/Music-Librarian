namespace DB.Entities
{
	public class WorkoutHasTimes
	{
		public int WorkoutId{ get; set; }
		public virtual Workout Workout { get; set; }
		public int WorkoutTimeId{ get; set; }
		public virtual WorkoutTime WorkoutTime{ get; set; }
	}
}