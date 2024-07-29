using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        public string StudentFName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string StudentLName { get; set; } = string.Empty;

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; } = string.Empty;

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrolDate { get; set; }
    }
}
