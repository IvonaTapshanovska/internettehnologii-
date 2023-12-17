using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Subject
    {
        public Subject() {
        
        Students = new List<Student>();
        Grades=new List<StudentSubjectGrades>();
        }
        public string Name { get; set; }
        [Key]
        public int SubjectId { get; set; }
        public List<StudentSubjectGrades> Grades { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}