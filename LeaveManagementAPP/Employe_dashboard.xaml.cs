using LeaveManagementAPP.Model;
using LeaveManagementAPP.ViewModel;
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
        LMDbContext context = new LMDbContext();
        Employee Data { get; set; } 
        public Employe_dashboard(Employee data)
        {
            InitializeComponent();
            Data = data;
            DataInsert();

        }
        private void Leave_button(object sender, RoutedEventArgs e)
        {
            
            Leave_DBoard ld = new Leave_DBoard(Data);
            ld.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
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
        public void DataInsert()
        {
            //Connection
            var bd = new LMDbContext();

            //Setting Data inside textboxes

            textBoxID.Text = Data.EmpID.ToString();
            textBoxName.Text = Data.EmpName;
            textBoxGender.Text = Data.EmpGender;
            textBoxEmail.Text = Data.EmpEmail;
            textBoxAddress.Text = Data.EmpAddress;
        }   
    }       
}
