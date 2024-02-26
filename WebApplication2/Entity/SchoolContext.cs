using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2.Entity
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentDepartment> StudentDepartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDepartment>()
                .HasKey(sd => new { sd.StudentId, sd.DepartmentId });

            modelBuilder.Entity<StudentDepartment>()
                .HasOne(sd => sd.Student)
                .WithMany(s => s.StudentDepartments)
                .HasForeignKey(sd => sd.StudentId);

            modelBuilder.Entity<StudentDepartment>()
                .HasOne(sd => sd.Department)
                .WithMany(d => d.StudentDepartments)
                .HasForeignKey(sd => sd.DepartmentId);
        }
    }
}