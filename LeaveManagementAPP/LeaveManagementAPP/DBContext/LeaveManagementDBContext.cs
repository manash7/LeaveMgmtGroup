using LeaveManagementAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.DBContext
{
    public class LeaveManagementDBContext : DbContext
    {

        
        public LeaveManagementDBContext()
        {
        }

        public LeaveManagementDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RameshDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        

    public DbSet<User> Users { get; set; }
    }

}
