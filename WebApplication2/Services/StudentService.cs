using System.Linq;
using WebApplication2.DTOs;
using WebApplication2.Entity;
using WebApplication2.Services;

namespace WebApplication2
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _context;

        public StudentService(SchoolContext context)
        {
            _context = context;
        }

        public List<StudentWithDepartmentsDTO> GetAllStudentsWithDepartments()
        {
            var studentsWithDepartments = _context.Students
                .Select(s => new StudentWithDepartmentsDTO
                {
                    StudentId = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    Address = s.Address,
                    Image = s.Image,
                    Departments = s.StudentDepartments.Select(sd => sd.Department.Name).ToList()
                })
                .ToList();

            return studentsWithDepartments;
        }
    }
}
