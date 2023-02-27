using LeaveManagementAPP.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ViewModel
{
    class LMDbContext : DbContext
    {
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Leave> Leaves { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpID);
            });
            modelBuilder.Entity<Admin>().HasKey(e => e.AdminID);
            modelBuilder.Entity<Category>().HasKey(e => e.CatID);
            modelBuilder.Entity<Leave>().HasKey(e => e.LID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = leavemanagement; Trusted_Connection = SSPI; MultipleActiveResultSets = true; TrustServerCertificate = true");
        }
    }
}
