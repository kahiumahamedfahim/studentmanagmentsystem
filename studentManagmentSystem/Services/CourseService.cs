using studentManagmentSystem.Repository.Interfaces;
using studentManagmentSystem.Services.Interfaces;

namespace studentManagmentSystem.Services
{
    public class CourseService:ICourseService
    {
        public readonly ICourseRepository _repo;
        public CourseService(ICourseRepository courseRepository)
        {
            _repo= courseRepository;
        }
    }
}
