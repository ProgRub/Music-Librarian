using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class WorkoutHasTimesRepository : GenericRepository<WorkoutHasTimes>,IWorkoutHasTimesRepository
    {
        public WorkoutHasTimesRepository(DatabaseContext context) : base(context)
        {
        }
    }
}