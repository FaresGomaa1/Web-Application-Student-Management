using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentWithDepartmentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentWithDepartmentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet("withDepartments")]
        public IActionResult GetStudentsWithDepartments()
        {
            var studentsWithDepartments = _studentService.GetAllStudentsWithDepartments();
            return Ok(studentsWithDepartments);
        }
    }
}
