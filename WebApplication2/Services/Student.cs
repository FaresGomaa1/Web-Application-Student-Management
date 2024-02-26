using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Entity;
using WebApplication2.Model;

namespace WebApplication2.Services
{
    public class StudentService : IStudent
    {
        private readonly SchoolContext _context;

        public StudentService(SchoolContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
                return _context.Students.ToList();

      
        }

        public void UpdateStudent(Student std)
        {
            try
            {
                _context.Students.Update(std);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error occurred while updating student: {ex.Message}");

            }
        }

        public void DeleteStudent(int stdId)
        {
            try
            {
                var student = _context.Students.Find(stdId);
                if (student != null)
                {
                    _context.Students.Remove(student);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error occurred while deleting student: {ex.Message}");

            }
        }

        public void AddStudent(Student std)
        {
            try
            {
                _context.Students.Add(std);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding student: {ex.Message}");
            }
        }
    }
}