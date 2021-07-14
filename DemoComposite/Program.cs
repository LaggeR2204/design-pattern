using System;

namespace DemoComposite
{
    class Program
    {
        static Component Order() {
            Box package = new Box();
            Box box1 = new Box();
            Box box2 = new Box();

            box1.Add(new Iphone());
            box1.Add(new Iphone());

            box2.Add(new PS5());
            box2.Add(new Iphone());

            package.Add(box1);
            package.Add(new PS5());
            package.Add(new Iphone());
            package.Add(box2);

            return package;
        }
        static void Main(string[] args)
        {
            Component package = Order();

            Console.WriteLine($"Total Price: {package.GetPrice()}");
            Console.WriteLine($"Package contain {package.GetContent()}");
            
            Console.Read();
        }
    }
}
