using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Display(Name = "First Name")]
        public string TeacherFName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string TeacherLName { get; set; } = string.Empty;

        [Display(Name = "Employee Number")]
        public string EmployeeNumber { get; set; } = string.Empty;

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Salary")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
