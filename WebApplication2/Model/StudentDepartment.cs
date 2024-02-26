namespace WebApplication2.Model
{
    public class StudentDepartment
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
