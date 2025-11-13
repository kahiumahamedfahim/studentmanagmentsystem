namespace studentManagmentSystem.Entity
{
    public class Course
    {
        public int CourseId {  get; set; }
        public string? CourseName { get; set; }

        public List<Department>? Departments { get; set; }
        public List<Student> Students { get; set; }
        public List<MajorCourse> MajorCourses { get; set; } = new();
        public List<MinorCourse> MinorCourses { get; set; } = new();
    }
}
