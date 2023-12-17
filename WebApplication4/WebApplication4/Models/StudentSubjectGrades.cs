using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class StudentSubjectGrades
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int selectedStudent { get; set; }

        public List<Student> students { get; set; }

        [Range(5,10)]
        public int Grade { get; set; }

        public StudentSubjectGrades() { 
        
            students = new List<Student>();
        }
    }
}