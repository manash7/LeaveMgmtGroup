using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.model
{
    public class Employee_Manage
    {
        [Key]
        public int Emp_ID { get; set; }
        public string? Emp_Name { get; set; }
        
        public string? Emp_Gender { get; set; }
        public string? Emp_Phone { get; set; }
        public string? Emp_Address { get; set; }
        
    }
}
