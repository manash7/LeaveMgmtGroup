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
        public LeavesView()
        {
            InitializeComponent();
            LeaveDataTable();
            MessageBox.Show("Working Fine");
        }



        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var context = new LMDbContext();

            var leave = new Leave()
            {
                StartDate = DateStart.SelectedDate,
                EndDate = DateEnd.SelectedDate,
                Status = Status.Text,
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
