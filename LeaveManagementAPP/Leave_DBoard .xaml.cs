using LeaveManagementAPP.Model;
using LeaveManagementAPP.View;
using LeaveManagementAPP.ViewModel;
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
using System.Windows.Shapes;

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for Leave_DBoard.xaml
    /// </summary>
    public partial class Leave_DBoard : Window
    {
        private readonly Leave_crud_services _crudServices;
        LMDbContext context = new LMDbContext();
        Employee Data { get; set; }

        public Leave_DBoard(Employee data)
        {
            InitializeComponent();
            Data = data;
            _crudServices = new Leave_crud_services();
            leave_list_Button_Click();
            settingData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        // Leave Apply Button Functionality
        private async void DrawCircleButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validation for Non Empty fields and Correct Date selection 
                if (textBoxName.Text != string.Empty && ComboCategory.Text != string.Empty)
                {
                    if (StartDate.SelectedDate > DateTime.Today && EndDate.SelectedDate > DateTime.Today)
                    {
                        await _crudServices.AddBrand(textBoxName.Text, int.Parse(textBoxID.Text), ComboCategory.Text, (DateTime)StartDate.SelectedDate, (DateTime)EndDate.SelectedDate);
                        MessageBox.Show("Leave Applied successfullly");
                    }
                    else
                    {
                        throw new Exception("Date Cannot be Past One");
                    }


                }
                else
                {
                    throw new Exception("Fields Cannot be empty");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                await ListBrands();

                leave_list_Button_Click();

                ComboCategory.SelectedItem = null;

            }
        }
        //List of leave applied 
        private async Task ListBrands()
        {
            //var brandList = await _crudServices.ListBrands();
            var brandList = context.Leaves.Include(l => l.Employee).Where(e => e.EmployeeID == Data.EmpID).ToList();
                //.Where(e => e.EmployeeID == Data.EmpID).ToList();
            DataGridBrand.ItemsSource = brandList;
        }

        // Delete Button Functionality
        private async void DrawCircleButton3_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                if (textBoxID.Text != string.Empty && textBoxName.Text != string.Empty)
                {

                    await _crudServices.DeleteBrand(int.Parse(textBoxLid.Text));
                    MessageBox.Show("Leave WithDraw Successfully");

                }
                else
                {
                    throw new Exception("Field Cannot be empty");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await ListBrands();
                

            }
        }

        //Update Button Functionality

        private async void Edit_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxID.Text != string.Empty && textBoxName.Text != string.Empty)
                {
                    await _crudServices.UpdateBrand(int.Parse(textBoxLid.Text), ComboCategory.Text, (DateTime)StartDate.SelectedDate, (DateTime)EndDate.SelectedDate);
                    throw new Exception("Data Successfully Updateddd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await ListBrands();
            }
        }

        // DataGrid Functionality for Displying details of Leave Applied 
        private void DataGridBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                var activelist = (Leave)DataGridBrand.CurrentItem;

                if (activelist != null)
                {
                    textBoxLid.Text = activelist.LID.ToString();
                    textBoxID.Text = activelist.EmployeeID.ToString();
                    var data = context.Employees.Where(c => c.EmpID == activelist.EmployeeID).FirstOrDefault();
                    if (data != null)
                    {
                        textBoxName.Text = data.EmpName;

                    }
                    ComboCategory.SelectedItem = activelist.LeaveCategory;
                    StartDate.SelectedDate = activelist.StartDate;
                    EndDate.SelectedDate = activelist.EndDate;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Leave list button Functionality
        private async void leave_list_Button_Click()
        {
            try
            {
                await ListBrands();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Profilr Button Navigation 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Employe_dashboard ed = new Employe_dashboard(Data);
            ed.Show();
            Close();
        }
        private void settingData()
        {
            //Setting Data to the 

            textBoxID.Text = Data.EmpID.ToString();
            textBoxName.Text = Data.EmpName;

            //Populating Category combo box
            ComboCategory.ItemsSource = context.Categories.Select(e => e.CategoryName).ToArray();
            //comboStatus.ItemsSource = new string[] { "Approved", "Pending", "Denied" };
        }
    }
}
