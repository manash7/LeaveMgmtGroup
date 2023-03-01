using LeaveManagementAPP.ViewModel;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        LMDbContext context = new LMDbContext();
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //var Check = context.Employees.Where(e=> e.EmpEmail == textEmail.Text).Select(e=> new { Email = e.EmpEmail }).Contains(e.emp);
            var data = context.Employees.Where(c => c.EmpEmail == textEmail.Text).FirstOrDefault();

            //Checking For Null Values 
            if (textEmail.Text == null || textPassword == null)
            {
                MessageBox.Show("Please Enter Values");
            }
            else if (textEmail.Text == data.EmpEmail && textPassword.Password == data.EmpPassword)
            {
                //MessageBox.Show("Login Successful");
                if (data.Is_SuperUser == false)
                {
                    // MessageBox.Show("Not a Super USer");
                    Window emp = new Employe_dashboard(data);
                    emp.Show();
                    Close();
                }
                else
                {
                    Window admin = new MainWindow();
                    admin.Show();
                    Close();
                }
            }

            else
            {
                MessageBox.Show("Invalid Credentials...");
            }


        }
    }
}
