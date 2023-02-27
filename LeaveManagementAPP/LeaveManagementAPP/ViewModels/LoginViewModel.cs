using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.Models;
using LeaveManagementAPP.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace LeaveManagementAPP.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        

        public LoginViewModel()
        {
            //_dbContext = dbContext;
            //LoginCommand = new RelayCommand(Execute, CanExecute);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _isSuperUser;
        public bool CheckSuperUser
        {
            get { return _isSuperUser; }
            set
            {
                if (_isSuperUser != value)
                {
                    _isSuperUser = value;
                    OnPropertyChanged(nameof(CheckSuperUser));
                    
                }
            }
        }


        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                LeaveManagementDBContext _dbContext = new LeaveManagementDBContext();

                // Retrieve the user from the database that matches the input username
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == username);

                // If no user was found, return false
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return false;
                }

                // Compare the plain text password with the password stored in the database
                if (password == user.Password && user.Is_SuperUser)
                {
                    //MessageBox.Show("Logged in.");
                    CheckSuperUser = true;
                    OnPropertyChanged(nameof(CheckSuperUser));
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid login.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


    }
}
