using WebApplication2.Model;

namespace WebApplication2.Services
{
    public interface IDepartment
    {
        List<Department> GetAll();
        void UpdateDepartment(Department dept);
        void DeleteDepartment(int deptId);
        void AddDepartment(Department dept);
    }
}