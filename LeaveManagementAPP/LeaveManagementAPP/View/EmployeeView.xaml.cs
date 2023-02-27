using LeaveManagementAPP.Model;
using LeaveManagementAPP.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net;
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

namespace LeaveManagementAPP.View
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        List<Employee>? Emp { get; set; }

        public EmployeeView()
        {
            InitializeComponent();
            EmpDataTable();
            comboEmpGender.ItemsSource = new string[] { "Male", "Female" };
            EmployeeTable.SelectionChanged+= EmployeeTable_SelectionChanged;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

        public void EmpDataTable()
        {
            var context = new LMDbContext();
            var Emp = context.Employees.ToList();
            EmployeeTable.ItemsSource = Emp;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var context = new LMDbContext();

            var Emp = new Employee()
            {
                EmpName = textEmpName.Text,
                EmpAddress = textEmpAddress.Text,
                EmpEmail = textEmpEmail.Text,
                EmpPassword = textEmpPassword.Text,
                EmpGender = comboEmpGender.SelectedItem.ToString(),
            };

            context.Employees.Add(Emp);
            context.SaveChanges();
            EmpDataTable();

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var context = new LMDbContext();

            var Emp = new Employee()
            {
                EmpID = int.Parse(textEmpID.Text),
            };

            context.Employees.Remove(Emp);
            context.SaveChanges();
            EmpDataTable();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var context = new LMDbContext();

            var Emp = new Employee()
            {
                EmpID = int.Parse(textEmpID.Text),
                EmpName = textEmpName.Text,
                EmpAddress = textEmpAddress.Text,
                EmpEmail = textEmpEmail.Text,
                EmpPassword = textEmpPassword.Text,
                EmpGender = comboEmpGender.SelectedItem.ToString(),
            };

            context.Employees.Update(Emp);
            context.SaveChanges();
            EmpDataTable();
        }

        private void EmployeeTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var activelist = (Employee)EmployeeTable.CurrentItem;

            if (activelist != null)
            {
                textEmpID.Text = activelist.EmpID.ToString();
                textEmpName.Text = activelist.EmpName;
                textEmpAddress.Text = activelist.EmpAddress;
                textEmpEmail.Text = activelist.EmpEmail;
                textEmpPassword.Text = activelist.EmpPassword;

                comboEmpGender.SelectedItem= activelist.EmpGender;
                //CategoryID
                //LeaveID   

            }
        }
    }
}
