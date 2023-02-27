using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.Models;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeaveManagementAPP.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        //private readonly LeaveManagementDBContext _dbContext;

        LeaveManagementDBContext _dbContext = new LeaveManagementDBContext();
        public UserControl1()
        {
            InitializeComponent();
            //_dbContext = dbContext;
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            

            User obj = new User();
            obj.Name = textBoxName.Text;
            obj.UserName = textBoxUserName.Text;
            obj.Email = textBoxEmail.Text;
            obj.Password = passwordBox1.Password;
            obj.Is_SuperUser = CheckSuperUser.IsChecked.Value;
            _dbContext.Users.Add(obj);
            _dbContext.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
