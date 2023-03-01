using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    public class Leave
    {
        [Key]
        public int LID { get; set; }
        public string? LeaveCategory{ get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }

        public string? Desc { get; set; }

        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }



    }
}
