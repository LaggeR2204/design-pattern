using System;

namespace DemoAbstracFactory
{
    public class Client
    {
        private IFurnitureFactory factory;

        public Client(IFurnitureFactory _factory)
        {
            factory = _factory;
        }
        public void doSomething()
        {
            var chairProduct = factory.createChair();
            var sofaProduct = factory.createSofa();
            var coffeeTableProduct = factory.createCoffeeTable();

            Console.WriteLine(chairProduct.hasLegs());
            Console.WriteLine(chairProduct.sitOn());
            Console.WriteLine(sofaProduct.hasLegs());
            Console.WriteLine(sofaProduct.sitOn());
            Console.WriteLine(coffeeTableProduct.hasLegs());
            Console.WriteLine(coffeeTableProduct.sitOn());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ModernFurnitureFactory());
            client.doSomething();
            Console.ReadKey();
        }
    }
}
