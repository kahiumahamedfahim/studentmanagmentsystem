using studentManagmentSystem.Models;
namespace studentManagmentSystem.Services.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetAllCourses();

        // Get course by Id
        CourseViewModel? GetCourseById(int courseId);

        // Add new course (ViewModel -> Entity mapping inside service)
        bool AddCourse(CourseViewModel courseVm);

        // Update course
        bool UpdateCourse(CourseViewModel courseVm);

        // Delete course by Id
        bool DeleteCourse(int courseId);

        // Get courses by Department Id
       
    }
}
