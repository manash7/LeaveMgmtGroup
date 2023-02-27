using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.ViewModels;
using LeaveManagementAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly LoginViewModel _loginViewModel;

        public MainWindow()
        {
            InitializeComponent();
            
            //DataContext = new LoginViewModel(dbContext);
        }

        //private void LoginViewModel_LoginSuccessful(object sender, EventArgs e)
        //{
        //    // Implement the logic to navigate to the main application window
        //    MessageBox.Show("Login successful!");
        //}



    }
    
}
