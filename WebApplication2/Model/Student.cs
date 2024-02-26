using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Age must be a number")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Image path/URL is required")]
        public string Image { get; set; }
        public List<StudentDepartment> StudentDepartments { get; set; }
    }
}

