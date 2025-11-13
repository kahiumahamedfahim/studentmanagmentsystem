namespace studentManagmentSystem.Entity
{
    public class Department
    {
        public int DepartmentId {  get; set; }
        public string? DepartmentName { get; set; }
        public List<Course>? AllvalidCourses { get; set; }   

    }
}
