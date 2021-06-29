using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class WorkoutRepository : GenericRepository<Workout>,IWorkoutRepository
    {
        public WorkoutRepository(DatabaseContext context) : base(context)
        {
        }
    }
}