using WebApplication2.Model;

namespace WebApplication2.Services
{
    public interface IStudent
    {
        List<Student> GetAll();

        void UpdateStudent(Student Std);
        void DeleteStudent(int StdId);
        void AddStudent(Student Std);
    }
}
