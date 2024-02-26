using System.Collections.Generic;

namespace WebApplication2.DTOs
{
    public class StudentWithDepartmentsDTO
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public List<string> Departments { get; set; }
    }
}
