using System;

namespace FACTORY_METHOD
{
    public interface Transport
    {
        string Deliver();
    }

    class Truck : Transport
    {
        public string Deliver()
        {
            return "Truck: Deliver by land";
        }
    }

    class Ship : Transport
    {
        public string Deliver()
        {
            return "Ship: Deliver by sea";
        }
    }

    abstract class Logistics
    {
        public abstract Transport CreateTransport();

        public string PlanDelivery()
        {
            var transport = CreateTransport();
            var result = "Creator: The same creator's code has just worked with "
                + transport.Deliver();

            return result;
        }
    }

    class RoadLogistics : Logistics
    {
        public override Transport CreateTransport()
        {
            return new Truck();
        }
    }

    class SeaLogistics : Logistics
    {
        public override Transport CreateTransport()
        {
            return new Ship();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string config = "Truck";

            Logistics Logistics;

            switch(config)
            {
                case "Truck":
                    Logistics = new RoadLogistics();
                    break;
                case "Ship":
                    Logistics = new SeaLogistics();
                    break;
                default:
                    Logistics = null;
                    break;
            }

            Console.WriteLine(Logistics.PlanDelivery());
            Transport transport = Logistics.CreateTransport();
            Console.WriteLine(transport.Deliver());

            Console.ReadLine();
            
        }
    }
}
