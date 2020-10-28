using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class EmployeeEducation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeEducationID { get; set; }
        public string Qualification { get; set; }
        public float TenthGradeMark { get; set; }
        public float TwelfthGradeMark { get; set; }
        public string TwelfthSchoolName { get; set; }
      
        [Required]
        public ApplicationUser ApplicationUser { get; set; }


    }
}