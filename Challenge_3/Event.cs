using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Event
    {
        public Event() { }

        public Event(string events, int numberofpeopleattend,  double totalcostperevent, DateTime date)
        {
            Events = events;
            Numberofpeopleattend = numberofpeopleattend;
           Totalcostperevent = totalcostperevent;
            Date = date;
        }

        public string Events { get; set; }
        public int Numberofpeopleattend { get; set; }
        public double Totalcostperevent { get; set; }
        public DateTime Date { get; set; }
        public double costperperson => Totalcostperevent / Numberofpeopleattend;

        public override string ToString()
        {
            return $"{Events}\n" +
                  $"Number Of People Attended:{Numberofpeopleattend}\n" +
                  $"Total Cost Per Event: {Totalcostperevent}\n" +
                  $"Date of Outing: {Date} \n" +
                  $"Cost Per Person:{costperperson}\n";
        }

    }

}
