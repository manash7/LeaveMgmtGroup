using LeaveManagementAPP.Model;
using LeaveManagementAPP.ViewModel;
using Microsoft.EntityFrameworkCore.Diagnostics;
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

namespace LeaveManagementAPP.View
{
    /// <summary>
    /// Interaction logic for Category.xaml
    /// Author - Manash 
    /// This Modules holds the Functional part for the Category Xaml views 
    /// Performing The CRUD operation is functional Using EF core Framework
    /// </summary>
    /// 

    public partial class CategoryView : UserControl
    {
        // Creating Context For Connection to the Database and Manipulating Data 
        LMDbContext context = new LMDbContext();

        //Constructor CategoryView Class
        public CategoryView()
        {
            InitializeComponent();
            CatTable(); 
            CategoryTable.SelectionChanged+= CategoryTable_SelectionChanged;
        }

        //for updating the table when data changes
        private void CatTable()
        {
            LMDbContext context = new LMDbContext();
            var category = context.Categories.ToList();
            CategoryTable.ItemsSource = category;
        }

        //For populating TextBox When Selection Changes
        private void CategoryTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Selection Changes is used when we select any data inside Datagrid
            var activeList = (Category)CategoryTable.CurrentItem;
            if (activeList != null)
            {
                textCatID.Text = activeList.CatID.ToString();
                CatName.Text = activeList.CategoryName;
                CatLeave.Text = activeList.CategoryLeaveCount.ToString();
            }
        }

        //Adds Category data to the Category table  
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Creating Class object and storing data inside it 
            var category = new Category()
            {
                CategoryName = CatName.Text,
                CategoryLeaveCount = int.Parse(CatLeave.Text)
            };
            try
            {
                // Adds Data to The database
                context.Categories.Add(category);
                context.SaveChanges();

                //Show Message if Successful
                MessageBox.Show("Data Added Successfully...");
            }
            catch (Exception ex)
            {
                //
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Clear Fields
                ClearFields();

                //Update Table When Data Changes
                CatTable();

                category = null;
            }
        }

        //Update data to the Category table 
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            // Creating Class object and storing data inside it for Update
            var category = new Category()
            {
                CatID = int.Parse(textCatID.Text),
                CategoryName = CatName.Text,
                CategoryLeaveCount = int.Parse(CatLeave.Text)
            };
            try
            {
                LMDbContext context = new LMDbContext();

                // Updates The database
                context.Categories.Update(category);
                context.SaveChanges();

                //Show Message if successful edited 
                MessageBox.Show("Data Edited Successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //Update Table When Data Changes
                CatTable();
                //Clear Fields
                ClearFields();

                category = null;
            }   
        }

        //Delete data from the Category table 
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Creating Class object and storing data inside it for Deletion
            var category = new Category()
            {
                CatID = int.Parse(textCatID.Text),
            };
            try
            {
                LMDbContext context = new LMDbContext();

                // Removes Data to The database
                context.Categories.Remove(category);
                context.SaveChanges();
                MessageBox.Show("Data Deleted Successfully...");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Update Table When Data Changes
                CatTable();
                //Clear Fields
                ClearFields();

                category = null;
            }
        }

        //For Clearing Fields
        private void ClearFields()
        {
            textCatID.Clear();
            CatName.Clear();
            CatLeave.Clear();
        }  
    }
}
