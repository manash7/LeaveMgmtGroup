using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        [Key]
        public int CatID { get; set; }

        public string? CategoryName { get; set; }

        public int CategoryLeaveCount { get; set; }
    }
}
