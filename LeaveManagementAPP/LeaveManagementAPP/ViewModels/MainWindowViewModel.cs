using LeaveManagementAPP.DBContext;
using LeaveManagementAPP.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        //    private readonly LeaveManagementDBContext _dbContext;
        //    private UserControl2 loginControl;

        //    public UserControl2 LoginControl
        //    {
        //        get { return loginControl; }
        //        set
        //        {
        //            loginControl = value;
        //            OnPropertyChanged(nameof(UserControl2));
        //        }
        //    }

        //    public MainWindowViewModel(LeaveManagementDBContext dbContext)
        //    {
        //        _dbContext = dbContext;
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    protected virtual void OnPropertyChanged(string propertyName)
        //    {
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        public event PropertyChangedEventHandler? PropertyChanged;
    }

}
