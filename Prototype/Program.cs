using System;

namespace PrototypePatternDemo
{
    public class Car
    {
        public string Name;
        public string Color;
        public IdInfo IdInfo;

        public Car ShallowCopy()
        {
            return (Car) this.MemberwiseClone();
        }

        public Car DeepCopy()
        {
            Car clone = (Car) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Color = String.Copy(Color);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Color = "Red";
            car1.Name = "Lamborghini Aventador";
            car1.IdInfo = new IdInfo(666);

            // Perform a shallow copy of car1 and assign it to car2.
            Car car2 = car1.ShallowCopy();
            // Make a deep copy of car1 and assign it to car3.
            Car car3 = car1.DeepCopy();

            // Display values of car1, car2 and car3.
            Console.WriteLine("Original values of car1, car2, car3:");
            Console.WriteLine("   car1 instance values: ");
            DisplayValues(car1);
            Console.WriteLine("   car2 instance values:");
            DisplayValues(car2);
            Console.WriteLine("   car3 instance values:");
            DisplayValues(car3);

            // Change the value of car1 properties and display the values of car1,
            // car2 and car3.
            car1.Color = "Yellow";
            car1.Name = "Lamborghini Huracan";
            car1.IdInfo.IdNumber = 999;
            Console.WriteLine("\nValues of car1, car2 and car3 after changes to car1:");
            Console.WriteLine("   car1 instance values: ");
            DisplayValues(car1);
            Console.WriteLine("   car2 instance values (reference values have changed):");
            DisplayValues(car2);
            Console.WriteLine("   car3 instance values (everything was kept the same):");
            DisplayValues(car3);
        }

        public static void DisplayValues(Car c)
        {
            Console.WriteLine("      Name: {0:s}, Color: {1:s}",
                c.Name, c.Color);
            Console.WriteLine("      ID: {0:d}", c.IdInfo.IdNumber);
        }
    }
}
