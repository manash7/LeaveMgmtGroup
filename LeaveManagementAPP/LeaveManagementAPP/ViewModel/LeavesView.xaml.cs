using LeaveManagementAPP.Model;
using LeaveManagementAPP.ViewModel;
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
            comboCategory.ItemsSource = context.Categories.ToList().ToString();
        }



        private void Add_Click(object sender, RoutedEventArgs e)
        {
            

            var leave = new Leave()
            {
                StartDate = DateStart.SelectedDate,
                EndDate = DateEnd.SelectedDate,
                Status = comboStatus.Text,
                Desc = Desc.Text,
            };

            context.Leaves.Add(leave);
            context.SaveChanges();
        }

        public void LeaveDataTable()
        {
            var context = new LMDbContext();
            var leaves = context.Leaves.ToList();
            LeavesTable.ItemsSource = leaves;
        }
    }
}
