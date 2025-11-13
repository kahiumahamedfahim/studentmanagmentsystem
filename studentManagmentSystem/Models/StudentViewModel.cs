namespace studentManagmentSystem.Models
{
    public class StudentViewModel
    {
        public string? StudentId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Display image (from DB or storage path)
        public string? ImageUrl { get; set; }

        // For file upload from UI (optional)
        public IFormFile? ImageFile { get; set; }

        public string? GithubUrl { get; set; }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        // Courses
        public List<CourseViewModel>? AllCourses { get; set; }
        public List<CourseViewModel>? MajorCourses { get; set; }
        public List<CourseViewModel>? MinorCourses { get; set; }

        // Available courses for registration
        public List<CourseViewModel>? AvailableCourses { get; set; }
    }
}
