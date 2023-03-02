using LeaveManagementAPP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LeaveManagementAPP.ViewModel
{
    public class LMDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        

        //string conecctionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public LMDbContext()
        {
            
        }
        public LMDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Leave>()
            .HasOne<Employee>(l => l.Employee)
            .WithMany(e => e.Leaves)
            .HasForeignKey(l => l.EmployeeID)
            .OnDelete(DeleteBehavior.Cascade); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder().
                AddJsonFile("appsetting.json").Build();
            var configSection = configBuilder.GetSection("dbSetting");

            var client_connection = configSection["db_connectionString"] ?? null;

            //optionsBuilder.UseSqlServer("Server = localhost; Database = leavemanagement1; Trusted_Connection = SSPI; MultipleActiveResultSets = true; TrustServerCertificate = true");
            optionsBuilder.UseSqlServer(client_connection);

        }
    }
}
