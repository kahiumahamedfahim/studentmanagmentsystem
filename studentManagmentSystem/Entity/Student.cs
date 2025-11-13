using Microsoft.Identity.Client;

namespace studentManagmentSystem.Entity
{
    public class Student
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? StudentId {  get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth {  get; set; }
        public string? ImageUrl { get; set; }
        public string? GithubUrl {  get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public List<Course>? AllCourses { get; set; }
        public List<MajorCourse>? MajorCourses { get; set; }
        public List<MinorCourse>? MinorCourses { get; set; }
      
    }
}
