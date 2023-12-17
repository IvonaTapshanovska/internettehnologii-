using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Student
    {
        [Required]
        [Display(Name="Име")]
        public string  Name { get; set; }

        [StringLength(6, MinimumLength = 6)]
        public string Index { get; set; }

        [Key]
        public int StudentId { get; set; }

        public string StudentImage { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public Student() {
        
        Subjects = new List<Subject>();
        }



    }
}