using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuItem
    {
        // Properties 
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public MenuItem() { }

        public MenuItem(int number, string name, string description, string ingredients, decimal price)
        {
            Number = number;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
        //Override of ToString
        public override string ToString()
        {
            string stringToReturn = $"{Number}\t{Name}\t{Description}\t{Ingredients}\t{Price}";
            return stringToReturn;
        }

    }

}
