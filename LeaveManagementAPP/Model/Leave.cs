using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    class Leave
    {
        public int LID { get; set; }
        public int LeaveCategoryID { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public string? Desc { get; set; }

        public ICollection<Employee>Employees { get; set; }
    }
}
