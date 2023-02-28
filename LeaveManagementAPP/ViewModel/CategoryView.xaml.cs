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
    /// </summary>
    public partial class CategoryView : UserControl
    {
        LMDbContext context = new LMDbContext();
        public CategoryView()
        {
            InitializeComponent();
            CatTable(); 
            CategoryTable.SelectionChanged+= CategoryTable_SelectionChanged;
        }


        //Adds data to the Category table  
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var category = new Category()
                {
                    CategoryName = CatName.Text,
                    CategoryLeaveCount = int.Parse(CatLeave.Text)
                };
                context.Categories.Add(category);
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

                //Update Table
                CatTable();

                //Show Message
                MessageBox.Show("Data Added Successfully...");
            }
            

        }

        //Update data to the Category table 
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var category = new Category()
            {
                CatID = int.Parse(textCatID.Text),
                CategoryName = CatName.Text,
                CategoryLeaveCount = int.Parse(CatLeave.Text)
            };
            try
            {
                context.Categories.Update(category);
                context.SaveChanges();
                MessageBox.Show("Data Edited Successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                ClearFields();
                CatTable();

            }
            

        }

        //Delete data to the Category table 
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var category = new Category()
            {
                CatID = int.Parse(textCatID.Text),
            };
            try
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                ClearFields();
                CatTable();
                MessageBox.Show("Data Deleted Successfully...");
            }
        }

        private void ClearFields()
        {
            textCatID.Clear();
            CatName.Clear();
            CatLeave.Clear();
        }

        //for updating the table when data changes
        private void CatTable()
        {
            var category = context.Categories.ToList();
            CategoryTable.ItemsSource = category;   
        }

        //For populating the table 
        private void CategoryTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var activeList = (Category)CategoryTable.CurrentItem;
            if (activeList != null)
            {
                textCatID.Text = activeList.CatID.ToString();
                CatName.Text = activeList.CategoryName;
                CatLeave.Text = activeList.CategoryLeaveCount.ToString();
            }
        }
    }
}
