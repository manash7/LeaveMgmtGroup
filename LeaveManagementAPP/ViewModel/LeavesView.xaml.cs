
using LeaveManagementAPP.Model;
using LeaveManagementAPP.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeaveManagementAPP.View
{
    /// <summary>
    /// Interaction logic for Leaves.xaml
    /// </summary>
    public partial class LeavesView : UserControl
    {
        LMDbContext context = new LMDbContext();
        public LeavesView()
        {
            InitializeComponent();
            LeaveDataTable();
            LeaveTable.SelectionChanged += LeaveTable_SelectionChanged;
        }


        //Updates Employee data to the Category 
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            //var message = context.Employees.Where(e => e.EmpID == int.Parse(textEmpID.Text)).ToList();
            var leave = new Leave()
            {
                LID = int.Parse(textLID.Text),
                EmployeeID = int.Parse(textEmpID.Text),
                StartDate = DateStart.SelectedDate,
                EndDate = DateEnd.SelectedDate,
                Status = comboStatus.Text,
                LeaveCategory = comboCategory.SelectedItem.ToString()
            };
            try
            {
                LMDbContext context = new LMDbContext();

                context.Leaves.Update(leave);
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
                LeaveDataTable();

                leave = null;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e) 
        {
            var leave = new Leave()
            {
                LID = int.Parse(textLID.Text),
            };
            try
            {
                LMDbContext context = new LMDbContext();

                context.Leaves.Remove(leave);
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
                LeaveDataTable();

                leave = null;
            }
        }
        public void LeaveDataTable()
        {
            //Getting And Setting Data inside DataGrid
            var context = new LMDbContext();
            var leaves = context.Leaves.Include(l => l.Employee).Where(e => e.Status != "Approved").ToList();
            LeaveTable.ItemsSource = leaves;
            
            //Populating Values inside ComboBox
            comboStatus.ItemsSource = new string[] { "Approved", "Pending", "Denied" };
            comboCategory.ItemsSource = context.Categories.Select(e => e.CategoryName).ToArray();
        }

        private void LeaveTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var activelist = (Leave)LeaveTable.CurrentItem;

            if (activelist != null)
            {
                textLID.Text = activelist.LID.ToString();
                textEmpID.Text = activelist.EmployeeID.ToString();
                //textEmpName.Text = context.Leaves.Include(l => l.Employee.EmpID.Equals(((uint)activelist.EmployeeID)) ).ToString();
                var data = context.Employees.Where(c => c.EmpID == activelist.EmployeeID).FirstOrDefault();
                if (data != null)
                {
                    textEmpName.Text = data.EmpName;

                }
                //textEmpName.Text = context.Leaves.Where(l => l.Employee.EmpID.Equals((uint)activelist.EmployeeID)).ToString();
                comboStatus.SelectedItem = activelist.Status;
                DateStart.Text = activelist.StartDate.ToString();
                DateEnd.Text = activelist.EndDate.ToString();
                comboCategory.SelectedItem = activelist.LeaveCategory.ToString();
                

            }
        }

        private void ClearFields()
        {
            textEmpName.Clear();
            textLID.Clear();
            textEmpID.Clear();
            //DateStart;
            //DateEnd.Clear();
            comboStatus.SelectedItem = null;
            comboCategory.SelectedItem = null;

        }
    }
}
