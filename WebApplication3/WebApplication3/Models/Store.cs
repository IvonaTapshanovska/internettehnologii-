using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Store
    {
        [Key]
        public  int  Id { get; set; }
        public string Name { get; set; }
        public virtual  ICollection<Book> Books { get; set; }
        public Store ()
        {
            Books = new List<Book> ();  
        }
    }
}