
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
using LeaveManagementAPP.model;
using LeaveManagementAPP.ModelView;

namespace LeaveManagementAPP
{
    /// <summary>
    /// Interaction logic for Leave_DBoard.xaml
    /// </summary>
    public partial class Leave_DBoard : Window
    {
        private readonly Leave_crud_services _crudServices;
        public Leave_DBoard()
        {
            InitializeComponent();
            _crudServices = new Leave_crud_services();
            leave_list_Button_Click();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Leave Apply Button Functionality
        private async void DrawCircleButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validation for Non Empty fields and Correct Date selection 
                if (textBoxFirstName.Text != string.Empty && ComboBox1.Text != string.Empty)
                {
                    if(StartDate.SelectedDate> DateTime.Today && EndDate.SelectedDate>DateTime.Today)
                    {
                        await _crudServices.AddBrand(textBoxFirstName.Text, ComboBox1.Text, (DateTime)StartDate.SelectedDate, (DateTime)EndDate.SelectedDate);
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
                textBoxID.Clear();
                textBoxFirstName.Clear(); 
                textBoxFirstName.Focus();

                leave_list_Button_Click();

              
            }
        }
        //List of leave applied 
        private async Task ListBrands()
        {
            var brandList = await _crudServices.ListBrands();
            DataGridBrand.ItemsSource = brandList.ToList();
        }

        // Delete Button Functionality
        private async void DrawCircleButton3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxID.Text != string.Empty && textBoxFirstName.Text != string.Empty )
                {
                 
                        await _crudServices.DeleteBrand(int.Parse(textBoxID.Text));
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
                textBoxID.Clear();
                textBoxFirstName.Clear();
               
                textBoxID.Focus();


            }
        }

        //Update Button Functionality

        private async void Edit_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxID.Text != string.Empty && textBoxFirstName.Text != string.Empty)
                {
                    await _crudServices.UpdateBrand(int.Parse(textBoxID.Text), textBoxFirstName.Text, ComboBox1.Text, (DateTime)StartDate.SelectedDate, (DateTime)EndDate.SelectedDate);
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
                    var activelist = (Leave_Dashboard)DataGridBrand.CurrentItem;

                    if (activelist != null)
                    {
                        textBoxID.Text = activelist.ID.ToString();
                        textBoxFirstName.Text = activelist.Name;
                        ComboBox1.Text = activelist.Category;
                        StartDate.SelectedDate = activelist.DateStart;
                        EndDate.SelectedDate = activelist.DateEnd;
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
            Employe_dashboard ed = new Employe_dashboard();
            ed.Show();
            Close();
        }
    }
}
