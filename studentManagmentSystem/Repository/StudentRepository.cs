using Microsoft.EntityFrameworkCore;
using studentManagmentSystem.DataAccess;
using studentManagmentSystem.Entity;
using studentManagmentSystem.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace studentManagmentSystem.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }

        // Student + all related courses
        public Student? GetStudentWithCourses(string studentId)
        {
           var student = _context.Students
                .Include(s => s.MajorCourses)
                    .ThenInclude(mc => mc.Course)
                .Include(s => s.MinorCourses)
                    .ThenInclude(mc => mc.Course)
                .FirstOrDefault(s => s.StudentId == studentId);
            return student;
        }

        // Available courses based on department, excluding already taken
        public IEnumerable<Course> GetAvailableCourses(string studentId)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.MajorCourses)
                .Include(s => s.MinorCourses)
                .FirstOrDefault(s => s.StudentId == studentId);

            if (student == null)
                return Enumerable.Empty<Course>();

            // Already taken courses
            var takenCourseIds = student.MajorCourses.Select(mc => mc.CourseId)
                .Concat(student.MinorCourses.Select(mc => mc.CourseId))
                .ToList();

            // Available courses
            var availableCourses = _context.Courses
                .Where(c => c.Departments.Any(d => d.DepartmentId == student.DepartmentId)
                            && !takenCourseIds.Contains(c.CourseId))
                .ToList();

            return availableCourses;
        }

        // Add a course as Major
        public void AddMajorCourse(string studentId, int courseId)
        {
            var student = _context.Students
                .Include(s => s.MajorCourses)
                .FirstOrDefault(s => s.StudentId == studentId);

            if (student != null && !student.MajorCourses.Any(mc => mc.CourseId == courseId))
            {
                student.MajorCourses.Add(new MajorCourse
                {
                    StudentId = studentId,
                    CourseId = courseId
                });

                _context.SaveChanges();
            }
        }

        // Add a course as Minor
        public void AddMinorCourse(string studentId, int courseId)
        {
            var student = _context.Students
                .Include(s => s.MinorCourses)
                .FirstOrDefault(s => s.StudentId == studentId);

            if (student != null && !student.MinorCourses.Any(mc => mc.CourseId == courseId))
            {
                student.MinorCourses.Add(new MinorCourse
                {
                    StudentId = studentId,
                    CourseId = courseId
                });

                _context.SaveChanges();
            }
        }

       
    }
}
