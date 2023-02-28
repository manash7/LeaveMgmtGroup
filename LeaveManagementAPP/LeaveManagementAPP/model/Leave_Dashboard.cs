
using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementAPP.model
{
    public class Leave_Dashboard
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        //public string? LastName { get; set; }
        public string? Category { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set;}
        public string? status { get; set;}
    }
}
