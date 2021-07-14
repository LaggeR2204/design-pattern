using System;
using System.Collections.Generic;
using System.Threading;

namespace Restaurant
{
    public class MealFactory
    {
        private readonly Dictionary<string, IMealFlyweight> _meals = new Dictionary<string, IMealFlyweight>();

        public IMealFlyweight GetMeal(string key)
        {
            IMealFlyweight meal;

            if (_meals.ContainsKey(key))
            {
                return _meals[key];
            }

            switch (key)
            {
                case "Burger Meal":
                    meal = new BurgerMeal();
                    Thread.Sleep(1300);

                    break;

                case "Pizza Meal":
                    meal = new PizzarMeal();
                    Thread.Sleep(1300);

                    break;

                default:
                    throw new ArgumentException("Unknown meal");
            }

            _meals.Add(key, meal);

            return meal;
        }

        public void PrintMeals()
        {
            Console.WriteLine($"{_meals.Count} meals have been added to the cache.");
            Console.WriteLine("The following meals are available:");

            foreach (var meal in _meals)
            {
                Console.WriteLine($"{meal.Value.Name}");
            }
        }

        public void ListIMealFlyweight()
        {
            Console.WriteLine("We have " + _meals.Count + " flyweight");
        }
    }
}