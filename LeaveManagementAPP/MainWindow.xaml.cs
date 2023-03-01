using LeaveManagementAPP.View;
using LeaveManagementAPP.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Employee_Loaded(object sender, RoutedEventArgs e)
        {
            

            
        }

        private void Emp_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            UserControl u1 = new EmployeeView();
            ChangeArea.Children.Clear();
            ChangeArea.Children.Add(u1);
        }

        private void Category_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            UserControl u1 = new CategoryView();
            ChangeArea.Children.Clear();
            ChangeArea.Children.Add(u1);
        }

        private void Leave_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            UserControl u1 = new LeavesView();
            ChangeArea.Children.Clear();
            ChangeArea.Children.Add(u1);
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}
