namespace studentManagmentSystem.Entity
{
    public class MajorCourse
    {
        public string StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
