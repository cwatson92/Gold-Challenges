using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{

    public class ProgramUI
    {
        Greeting_Repository_Class  = new greetrepo();
        private List<Email> templist = new List<email>();

        public void run()
        {
            InitialPrompt();
        }
        public void InitialPrompt()
        {
            Console.WriteLine("Please choose an option: \n 1) Create a new customer \n 2) Read customer profile \n 3) Update customer field \n 4)Delete Customer Profile");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Create new customer();
            }
            else if (option == 2)
            {
                Read customer profile();
            }
            else if (option == 3)
            {
                Update customer field();
            }
            else if (option == 4)
                Delete Customer Profile
            }
        private void Create a new customer()
        {
            Console.WriteLine("Please insert customer First Name");
            string greeting = Console.ReadLine();

            Console.WriteLine("Please insert customer Last Name");
            string greeting = Console.ReadLine();

            Console.WriteLine("Please insert customer email");
            string greeting = Console.ReadLine();
            Console.WriteLine("Please insert custoemr current membership status");
            string greeting = Console.ReadLine();
            Console.Clear();
            InitialPrompt();

        }
        

        }

        private void DisplayList()
        {
            templist =greetingsrepo.GetList();
            foreach (Email item in templist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();
        }





      