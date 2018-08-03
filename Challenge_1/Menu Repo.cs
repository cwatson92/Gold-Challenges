using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Menu_Repo
    {

        
            List<MenuItem> _foodrepo = new List<MenuItem>();



        public void AddItemToList(MenuItem item)
        {
            _foodrepo.Add(item);
        }
        public List<MenuItem> getList()
        {
            return _foodrepo;
        }

        public void printList(List<MenuItem> theList)
        {
            foreach (MenuItem items in theList)
            {
                Console.WriteLine(items);
            }

        }

        public void
            (string Name)
                
            {
               string menuprepo = Menu_Repository.FindIndex(food => food.Name == Name); //removing an item
        _foodrepo.RemoveAt(theIndex);
            }

}