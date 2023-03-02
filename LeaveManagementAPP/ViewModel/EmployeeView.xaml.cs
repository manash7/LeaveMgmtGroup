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
    /// Author - Manash 
    /// This Modules holds the Functional part for the Employee Xaml views 
    /// Performing The CRUD operation is functional Using EF core Framework
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        // Creating Context For Connection to the Database and Manipulating Data 
        LMDbContext context = new LMDbContext();

        //Constructor of EmpoyeeView Class
        public EmployeeView()
        {
            InitializeComponent();
            EmpDataTable();
            EmployeeTable.SelectionChanged += EmployeeTable_SelectionChanged;
        }

        //for updating the table when data changes
        public void EmpDataTable()
        {
            var Emp = context.Employees.ToList();
            EmployeeTable.ItemsSource = Emp;
            comboEmpGender.ItemsSource = new string[] { "Male", "Female" };

        }

        //Adds Employee data to the Category table
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Creating Class object and storing data inside it for Adding
            var Emp = new Employee()
            {
                EmpName = textEmpName.Text,
                EmpAddress = textEmpAddress.Text,
                EmpEmail = textEmpEmail.Text,
                EmpPassword = textEmpPassword.Text,
                EmpGender = comboEmpGender.SelectedItem.ToString(),
            };

            try
            {
                LMDbContext context = new LMDbContext();

                // Updates The database
                context.Employees.Add(Emp);
                context.SaveChanges();

                //Show Message if successful Added 
                MessageBox.Show("Data Added Successfully...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Clear Fields
                ClearFields();

                //Update Table When Data Changes
                EmpDataTable();
            }



        }

        //Delete Employee data to the Category Table
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var Emp = new Employee()
            {
                EmpID = int.Parse(textEmpID.Text),
            };

            try
            {
                LMDbContext context = new LMDbContext();

                context.Employees.Remove(Emp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //Clear Fields
                ClearFields();

                //Update Table When Data Changes
                EmpDataTable();
            }
        }

        //Updates Employee data to the Category table
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            // Creating Class object and storing data inside it for Update 
            var Emp = new Employee()
            {
                EmpID = int.Parse(textEmpID.Text),
                EmpName = textEmpName.Text,
                EmpAddress = textEmpAddress.Text,
                EmpEmail = textEmpEmail.Text,
                EmpPassword = textEmpPassword.Text,
                EmpGender = comboEmpGender.SelectedItem.ToString(),
            };

            try
            {
                LMDbContext context = new LMDbContext();

                //context.Entry().State = EntityState.Detached;
                context.Employees.Update(Emp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //Clear Fields
                ClearFields();

                //Update Table When Data Changes
                EmpDataTable();
            }  
        }

        //For populating TextBox When Selection Changes
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
                comboEmpGender.SelectedItem = activelist.EmpGender;

            }
        }
        private void ClearFields()
        {
            textEmpID.Clear();
            textEmpName.Clear();
            textEmpAddress.Clear();
            textEmpEmail.Clear();
            textEmpPassword.Clear();
            //comboEmpGender.Items.Clear();
        }
    }
}
