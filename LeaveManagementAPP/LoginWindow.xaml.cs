using LeaveManagementAPP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


            //Checking For Null Values 
            if (textEmail.Text.Length == 0 )
            {
                MessageBox.Show("Please Enter Values");
            }
            else if ((!Regex.IsMatch(textEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")))
            {
                MessageBox.Show("Please Enter Valid Email");
                textEmail.Focus();
            }
            else if (textPassword.Password.Length == 0)
            {
                MessageBox.Show("Please Enter Password");
            }
            //else if (textEmail.Text == data.EmpEmail && textPassword.Password == data.EmpPassword)
            //{
            //    //MessageBox.Show("Login Successful");
            //    if (data.Is_SuperUser == false)
            //    {
            //        // MessageBox.Show("Not a Super USer");
            //        Window emp = new Employe_dashboard(data);
            //        emp.Show();
            //        Close();
            //    }
            //    else
            //    {
            //        Window admin = new MainWindow();
            //        admin.Show();
            //        Close();
            //    }
            //}
            else
            {
                var data = context.Employees.Where(c => c.EmpEmail == textEmail.Text).FirstOrDefault();

                if (textEmail.Text == data.EmpEmail && textPassword.Password == data.EmpPassword)
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
            }
        }
    }
}
