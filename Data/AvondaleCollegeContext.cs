using Avondale_College.Models;
using Microsoft.EntityFrameworkCore;


namespace Avondale_College.Data
{
    public class AvondaleCollegeContext : DbContext
    {
        public AvondaleCollegeContext(DbContextOptions<AvondaleCollegeContext> options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher>  Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
        }
    }
}
