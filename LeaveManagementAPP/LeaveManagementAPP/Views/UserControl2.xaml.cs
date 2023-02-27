using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.Models;
using LeaveManagementAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeaveManagementAPP.Views
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        LeaveManagementDBContext _dbContext = new LeaveManagementDBContext();

        
        public UserControl2()
        {
            InitializeComponent();
            
            this.DataContext = new LoginViewModel();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = UserName.Text;
            string password = passwordBox1.Text;
            Debug.WriteLine(username+ ":" + password);

            LoginViewModel loginViewModel = this.DataContext as LoginViewModel;
            if (loginViewModel != null)
            {
                loginViewModel.LoginAsync(username, password);
            }


        }

    }
}
