using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Entity;
using WebApplication2.Model;

namespace WebApplication2.Services
{
    public class DepartmentService : IDepartment
    {
        private readonly SchoolContext _context;

        public DepartmentService(SchoolContext context)
        {
            _context = context;
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public void UpdateDepartment(Department dept)
        {
            try
            {
                _context.Departments.Update(dept);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while updating department: {ex.Message}");
            }
        }

        public void DeleteDepartment(int deptId)
        {
            try
            {
                var department = _context.Departments.Find(deptId);
                if (department != null)
                {
                    _context.Departments.Remove(department);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deleting department: {ex.Message}");
            }
        }

        public void AddDepartment(Department dept)
        {
            try
            {
                _context.Departments.Add(dept);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding department: {ex.Message}");
            }
        }
    }
}