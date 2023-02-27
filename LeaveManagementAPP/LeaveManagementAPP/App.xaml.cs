using LeaveManagementAPP.DBContext;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
//using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LeaveManagementAPP.ViewModels;
using Microsoft.Extensions.Options;

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    var services = new ServiceCollection();
        //    services.AddDbContext<LeaveManagementDBContext>(options =>
        //        options.UseSqlServer("Server=.;Database=RameshDB;Trusted_Connection=True;TrustServerCertificate=True;"));

        //    Register your other services here
        //    services.AddSingleton<LoginViewModel>();

        //    var serviceProvider = services.BuildServiceProvider();
        //    var loginViewModel = serviceProvider.GetService<LoginViewModel>();
        //    var optionsBuilder = new DbContextOptionsBuilder<LeaveManagementDBContext>();
        //    optionsBuilder.UseSqlServer("Server=.;Database=RameshDB;Trusted_Connection=True;TrustServerCertificate=True;");
        //    var options = optionsBuilder.Options;
        //    var dbContext = new LeaveManagementDBContext(options);
        //    var mainWindow = new MainWindow(dbContext);
        //    mainWindow.Show();
        //}






    }
}
