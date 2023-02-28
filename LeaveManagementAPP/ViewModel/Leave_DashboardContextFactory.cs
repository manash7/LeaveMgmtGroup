using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ViewModel
{
    internal class Leave_DashboardContextFactory
    {
        //public class Leave_DashboardContextFactory : IDesignTimeDbContextFactory<Leave_DashboardDBContext>
        //{
        //    public Leave_DashboardDBContext CreateDbContext(string[] args = null)
        //    {

        //        // Database connectivity functionality --setting up database server and database name 
        //        var options = new DbContextOptionsBuilder<Leave_DashboardDBContext>();
        //        options.UseSqlServer("Server = localhost\\SQLEXPRESS01; Database = LMS; Trusted_Connection = SSPI; MultipleActiveResultSets = true; TrustServerCertificate = true");
        //        return new Leave_DashboardDBContext(options.Options);
        //    }
        //}
    }
}
