using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for Employe_dashboard.xaml
    /// </summary>
    public partial class Employe_dashboard : Window
    {
        public Employe_dashboard()
        {
            InitializeComponent();
        }
        private void Leave_button(object sender, RoutedEventArgs e)
        {
            //Leave_DBoard ld = new Leave_DBoard();
            //ld.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DrawCircleButton1_Click(object sender, RoutedEventArgs e)
        {

            //var Emp = new Employee_Manage()
            //{
            //    Emp_Name = "vijay Karsh",
            //};

            //using Leave_DashboardDBContext context = _contextFactory.CreateDbContext();
            //context.Add(Emp);
            //context.SaveChanges();

        }
    }
}
