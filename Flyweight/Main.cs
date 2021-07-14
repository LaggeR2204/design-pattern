using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class RestaurantMealService
    {
        static void Main(string[] args)
        {
            var mealFactory = new MealFactory();
            mealFactory.PrintMeals();

            var watch = new System.Diagnostics.Stopwatch();
            mealFactory.ListIMealFlyweight();

            watch.Start();
            var mediumBurgerMeal = mealFactory.GetMeal("Burger Meal");
            mediumBurgerMeal.Serve("medium");
            mealFactory.ListIMealFlyweight();
            var mediumPizzaMeal = mealFactory.GetMeal("Pizza Meal");
            mediumPizzaMeal.Serve("medium");
            mealFactory.ListIMealFlyweight();

            var largeBurgerMeal = mealFactory.GetMeal("Burger Meal");
            largeBurgerMeal.Serve("large");
            mealFactory.ListIMealFlyweight();
            var largePizzaMeal = mealFactory.GetMeal("Pizza Meal");
            largePizzaMeal.Serve("large");
            mealFactory.ListIMealFlyweight();
            watch.Stop();

            mealFactory.PrintMeals();

            Console.WriteLine("Time init meal: " + watch.ElapsedMilliseconds);
        }
    }
}
