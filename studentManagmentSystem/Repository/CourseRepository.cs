using studentManagmentSystem.DataAccess;
using studentManagmentSystem.Entity;
using studentManagmentSystem.Repository.Interfaces;

namespace studentManagmentSystem.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base (context)
        {
            
        }
    }
}
