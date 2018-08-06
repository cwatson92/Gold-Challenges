using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{

    public class CreateANewCustomer
    {
        GreetingRepo email = new GreetingRepo();
        public List<Greeting> templist = new List<Greeting>();

        //1
        public GreetingRepo email = new GreetingRepo  ();
        //2
        public void Run()
        {//3
            //4
            CreateSeedList();
            //5
            RunStartMenu();

        }

        private void CreateSeedList()
        {
            throw new NotImplementedException();
        }

        //6
        private void RunStartMenu()
        {
            //7
            ShowStartMenu();

            //13
            bool continueToRunMenu = true;
            //14
            while (continueToRunMenu)
            {
                //9            //8
                int choice = GetAndParseMenuChoice();

                //10
                switch (choice)
                {
                    //11
                    case 1:
                        CreateANewCustomer();
                        break;
                    case 2:
                        ReadCustomerProfile();
                        break;
                    case 3:
                        UpdateCustomerProfile();
                        break;
                    case 4:
                        DeleteCustomerProfile
                        break;
                    case 5:
                       Exit Program
                        break;
                    case 6:
                        continueToRunMenu = false; //15
                        break;
                    default:
                        ShowStartMenu(); //16
                        break;
                }
                Console.Clear();
                Console.WriteLine("Don't Worry Be Happy!");
            }
        }

        private void ShowStartMenu()
        {
            Console.WriteLine("What would you like to do? \n " +
                "1. Create a new customer \n " +
                "2. Read customer profile \n " +
                "3. Update customer field \n " +
                "4.Delete Customer Profile \n" +
                "5.Exit Program");
        }

        private int GetAndParseMenuChoice()
        {
            Console.WriteLine("Please choose what you'd like to do from the menu:");
            string choiceasString = Console.ReadLine();
            int choice = Int32.Parse(choiceasString);

            return choice;
        }

        private void CreateSeedList()
        {
            Greeting JoeBush = new Greeting("joe", "bush", "current", "joebush1@aol.com");
            Greeting CassandraWatson = new Greeting("cassandra", "watson", "past", "cassandrawatson2@yahoo.com");
            Greeting CurtisLee = new Greeting("curtis", "lee", "potential", "curtis_lee50@gmail.com");

            GreetingRepo.AddNewCustomerToList(JoeBush);
            GreetingRepo.AddNewCustomerToList(CassandraWatson);
            GreetingRepo.AddNewCustomerToList(CurtisLee);

        
 




        public void CreateANewCustomer()
        {
            Console.WriteLine("Please insert customer First Name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please insert customer Last Name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Please insert customer email");
            string email = Console.ReadLine();

            Console.WriteLine("Please insert customer current membership status");
            string type = Console.ReadLine();
            Console.Clear();
            InitialPrompt();

        }

            {

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





      