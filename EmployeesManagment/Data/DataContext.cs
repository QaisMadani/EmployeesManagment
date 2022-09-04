using EmpManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagment.Data
{
    public class DataContext :DbContext
    {
        public DataContext (DbContextOptions<DataContext> options):
            base (options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<EmployeesActivity> EmployeesActivity { get; set; }

    }
}