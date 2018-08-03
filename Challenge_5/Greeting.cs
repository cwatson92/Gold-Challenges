using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class Greeting
    {
        public Greeting() { }
        public Greeting(String firstname, String lastname, String type, String email)
        {
            FirstName = firstname;
            LastName = lastname;
            Type = type;
            Email = email;
        }
        
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        
        

    }
}
