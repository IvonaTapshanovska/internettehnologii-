using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class AddToStore
    {
        public AddToStore() {
        
            books = new List<Book>();
        }
       
        public int StoreId { get; set; }
        public List<Book> books { get; set; }   

        public int BookId { get; set; }
    }
}