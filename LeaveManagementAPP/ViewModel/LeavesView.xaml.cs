﻿
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

            comboStatus.ItemsSource = new string[] { "Approved", "Pending", "Denied" };

            LeaveTable.SelectionChanged += LeaveTable_SelectionChanged;
            comboCategory.ItemsSource = context.Categories.Select(e => e.CategoryName).ToArray();
            
        }



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
                LeaveCategory = comboCategory.Text,
            };

            context.Leaves.Update(leave);
            context.SaveChanges();
        }

        public void LeaveDataTable()
        {
            var context = new LMDbContext();
            var leaves = context.Leaves.ToList();
            LeaveTable.ItemsSource = leaves;
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
    }
}
