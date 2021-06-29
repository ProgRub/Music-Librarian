using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories.Implementations
{
    public class WorkoutTimeRepository : GenericRepository<WorkoutTime>,IWorkoutTimeRepository
    {
        public WorkoutTimeRepository(DatabaseContext context) : base(context)
        {
        }
    }
}