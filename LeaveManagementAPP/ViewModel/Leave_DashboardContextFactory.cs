using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LeaveManagementAPP.ViewModel
{

    public class Leave_DashboardContextFactory : IDesignTimeDbContextFactory<LMDbContext>
    {
        public LMDbContext CreateDbContext(string[] args = null)
        {

            // Database connectivity functionality --setting up database server and database name 
            var options = new DbContextOptionsBuilder<LMDbContext>();
            options.UseSqlServer("Server = localhost; Database = leavemanagement1; Trusted_Connection = SSPI; MultipleActiveResultSets = true; TrustServerCertificate = true");
            return new LMDbContext(options.Options);
        }
    }
}

