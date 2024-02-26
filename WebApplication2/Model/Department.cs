using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public List<StudentDepartment> StudentDepartments { get; set; }
    }
}

