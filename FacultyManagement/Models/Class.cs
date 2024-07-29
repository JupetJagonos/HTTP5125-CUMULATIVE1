using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Display(Name = "Class Code")]
        public string ClassCode { get; set; } = string.Empty;

        [Display(Name = "Teacher ID")]
        public int? TeacherId { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Finish Date")]
        [DataType(DataType.Date)]
        public DateTime? FinishDate { get; set; }

        [Display(Name = "Class Name")]
        public string ClassName { get; set; } = string.Empty;
    }
}
