using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    
     public class ProgramUI
     {
        Event_Repo outingrepo = new Event_Repo();
        private List<Event> templist = new List<Event>();

        public void run()
        {
            InitialPrompt();
        }
        public void InitialPrompt()
        {
            Console.WriteLine("Please choose an option: \n 1) Display list of all Events \n 2) Combine cost of all Events \n 3) Add an Event");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                DisplayList();
            }
            else if (option == 2)
            {
                CombineCost();
            }
            else if (option == 3)
            {
                AddEvent();
            }        
        }
        private void AddEvent()
        {
            Console.WriteLine("What event did you attend?");
            string outing = Console.ReadLine();

            Console.WriteLine("How many employees attended?");
            int numberofpeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the Total Cost of Event");
            double totalcost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("When did the event occur? Please write in this format mm / dd / yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Event newEvent = new Event(outing, numberofpeople, totalcost, date);
            outingrepo.AddNewEventsToList(newEvent);
            Console.Clear();
            InitialPrompt();

        }
        private void CombineCost()
        {
            Console.WriteLine("The Total cost of All Events Is: " + outingrepo.TotalcostofAllEvents());
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();


        }

        private void DisplayList()
        {
            templist = outingrepo.GetList();
            foreach (Event item in templist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();
        }





    }
}
