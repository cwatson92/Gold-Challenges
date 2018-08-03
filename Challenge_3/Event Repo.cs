using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Event_Repo
    {
        private List<Event> _Event = new List<Event>()
        {
        new Event("Golf",5000,30, DateTime.Parse("6/13/2018)")),
        new Event("Bowling",1000,20, DateTime.Parse("5/15/2018")),
        new Event("Amusement Park",7000,100, DateTime.Parse("7/15/2018")),
        new Event("Concert",1000,30, DateTime.Parse("8/19/2018")),


        };

        public double TotalcostofAllEvents()
        { 
            double sum = 0;
            foreach (Event outing in _Event)
            {
                sum += outing.Totalcostperevent;
            }
            return sum;
        }

        public List<Event> GetList()
        {
            return _Event;
        }
        public void AddNewEventsToList(Event newEvent)
        {
            _Event.Add(newEvent);
        }
        public void AddNewEventsToList(List<Event> events)
        {
            foreach (Event item in events)
            {
                _Event.Add(item);
            }
        }
    }
}

