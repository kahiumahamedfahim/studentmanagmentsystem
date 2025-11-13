namespace studentManagmentSystem.Models
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        // Departments for which this course is valid
        public List<DepartmentViewModel>? Departments { get; set; }

    }
}
