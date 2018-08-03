using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Greeting_Repository_Class
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
        public List<Greeting> FindCustomerByName(string name)
        {
            {
            List<string> names = new List<string>();
            }
            var findcustoemr = new Greeting();

            foreach (var greeting in _greeting)
            {
                if (name == greeting.FirstName)
                    FindCustomer = greeting;
            }
            break;
         }
      }
        return findcustomer
       
        



    
}
