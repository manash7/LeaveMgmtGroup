using LeaveManagementAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    class Employee
    {
        public int EmpID { get; set; }
        public int CategoryID { get; set; }
        public int LeaveID { get; set; }

        public string? EmpName { get; set; }
        public string? EmpPassword { get; set; }
        public string? EmpAddress { get; set; }
        public string? EmpEmail { get; set; }
        public string? EmpGender { get; set; }

    }
}
