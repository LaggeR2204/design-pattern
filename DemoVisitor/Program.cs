using System;

namespace DemoVisitor
{
    class Program
    {
        static Component Order()
        {
            Box package = new Box();
            Box box1 = new Box();
            Box box2 = new Box();

            box1.Add(new Iphone() { Ram = "8GB", CPU = "Apple A5" });
            box1.Add(new Iphone() { Ram = "6GB", CPU = "Apple A4" });

            box2.Add(new PS5() { Power = "340W", Weight = "4.5kg" });
            box2.Add(new Iphone() { Ram = "8GB", CPU = "Apple A5" });

            package.Add(box1);
            package.Add(new PS5() { Power = "340W", Weight = "4.5kg" });
            package.Add(new Iphone() { Ram = "8GB", CPU = "Apple A5" });
            package.Add(box2);

            return package;
        }
        static void Main(string[] args)
        {
            Component package = Order();

            Console.WriteLine($"Total Price: {package.GetPrice()}");
            Console.WriteLine($"Package contain {package.GetContent()}");

            IVisitor specsVisitor = new SpecificationVisitor();
            package.Accept(specsVisitor);
            Console.Read();
        }
    }
}
