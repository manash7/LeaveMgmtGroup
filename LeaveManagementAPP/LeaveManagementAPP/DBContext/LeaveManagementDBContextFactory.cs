using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.DBContext
{
    public class LeaveManagementDBContextFactory : IDesignTimeDbContextFactory<LeaveManagementDBContext>
    {
        public LeaveManagementDBContext CreateDbContext(string[] args = null)
        {
           var options = new DbContextOptionsBuilder<LeaveManagementDBContext>().UseSqlServer("Server=.;Database=RameshDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new LeaveManagementDBContext(options.Options);
        }

        
    }
}
