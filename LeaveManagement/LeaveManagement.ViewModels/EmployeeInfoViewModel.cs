using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagement.ViewModels
{
    public class EmployeeInfoViewModel
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Email { get; set; }
        public string ProjectsDone { get; set; }
        public string Bio { get; set; }
        public string Hobbies { get; set; }
        public string Address { get; set; }
        public float Contact { get; set; }
        public int EmployeeID { get; set; }
        public string Qualification { get; set; }
        public float TenthGradeMark { get; set; }
        public float TwelfthGradeMark { get; set; }
        public string TwelfthSchoolName { get; set; }
    }
}