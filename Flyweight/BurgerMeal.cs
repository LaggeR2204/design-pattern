using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class BurgerMeal : IMealFlyweight
    {
        private List<string> _partsOfMeal;

        public BurgerMeal()
        {
            Name = "Burger Meals";
            _partsOfMeal = new List<string> { "Burger", "Fries", "Coke" };
        }

        public string Name { get; }

        public void Serve(string size)
        {
            Console.WriteLine($"Served {Name} - {size}");
        }
    }
}
