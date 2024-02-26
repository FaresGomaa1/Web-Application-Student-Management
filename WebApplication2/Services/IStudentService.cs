using WebApplication2.DTOs;

namespace WebApplication2
{
    public interface IStudentService
    {
        List<StudentWithDepartmentsDTO> GetAllStudentsWithDepartments();
    }
}