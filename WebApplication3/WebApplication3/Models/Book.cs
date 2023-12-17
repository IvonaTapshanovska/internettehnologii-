using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Book
    {
        [Key]
        public  int  BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Store> stores { get; set; }

        public Book ()
        {
            stores = new List<Store> ();
        }

    }
}