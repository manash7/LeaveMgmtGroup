using LeaveManagementAPP.model;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementAPP.ModelView
{
    public class Leave_DashboardDBContext : DbContext
    {
        // Database set for Leave Dashboard
        public DbSet<Leave_Dashboard> Leave_Dashboard { get; set; }

        // Database set for Employee Dashboard
        public DbSet<Employee_Manage> Employee_Manages { get; set; }

        public Leave_DashboardDBContext()
        {
        }
        public Leave_DashboardDBContext(DbContextOptions options) : base(options)
        {
        }
        // Setting Primary key 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leave_Dashboard>().HasKey(e => e.ID);
            modelBuilder.Entity<Employee_Manage>().HasKey(e => e.Emp_ID);
        }
    }
}
