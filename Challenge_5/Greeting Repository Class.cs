using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class GreetingRepo
    {
        private List<Greeting> _greeting = new List<Greeting>();

        public List<Greeting> GetList()
        {
            return _greeting;
        }
        public void AddNewCustomerToList(Greeting email)
        {
            _greeting.Add(email);
        }

        public void RemoveCustomerFromList(Greeting email)
        {
            _greeting.Remove(email);
        }
        
            {
            List<string> names = new List<string>();
            }
            var findcustomer = new Greeting();

            foreach (var greeting in g)
            {
                if (name == greeting.FirstName)
                    FindCustomer = greeting;
            }
            break;
         }
      }
        return findcustomer
       
        



    
}
