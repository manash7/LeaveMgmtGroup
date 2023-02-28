using LeaveManagementAPP.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    class Employee
    {

        public int EmpID { get; set; }

        public string? EmpName { get; set; }
        public string? EmpEmail { get; set; }
        public string? EmpPassword { get; set; }
        public string? EmpAddress { get; set; }
        public string? EmpGender { get; set; }

        public bool Is_SuperUser { get; set; }

        public int LeaveID { get; set; } 
        public Leave Leave { get; set; }    

    }
}
