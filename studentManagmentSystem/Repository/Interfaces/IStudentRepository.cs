using studentManagmentSystem.Entity;
namespace studentManagmentSystem.Repository.Interfaces
{
    public interface IStudentRepository:IGenericRepositiry<Student>
    {
        Student? GetStudentWithCourses(string studentId);
        IEnumerable<Course> GetAvailableCourses(string studentId);
        void AddMajorCourse(string studentId, int courseId);
        void AddMinorCourse(string studentId, int courseId);

    }
}
