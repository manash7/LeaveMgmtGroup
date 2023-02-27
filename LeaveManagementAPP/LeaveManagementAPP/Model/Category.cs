using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    class Category
    {
        public int CatID { get; set; }

        public string? CategoryName { get; set; }

        public int CategoryLeaveCount { get; set; }
    }
}
