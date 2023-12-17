using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class AddToRole
    {
        public string Email { get; set; }
        public string selectedRole { get; set; }

        public List<string> roles { get; set; }

        public AddToRole() { 
        
            roles = new List<string>();
        }
    }
}