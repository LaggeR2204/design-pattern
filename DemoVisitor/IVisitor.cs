using System;
namespace DemoVisitor
{
    public interface IVisitor
    {
        void Visit(Iphone iphone);
        void Visit(PS5 ps5);
    }

    class SpecificationVisitor : IVisitor
    {
        public void Visit(Iphone iphone)
        {
            Console.WriteLine($"Iphone specs:\n\tCPU: {iphone.CPU}\n\tRam: {iphone.Ram}");
        }

        public void Visit(PS5 ps5)
        {
            Console.WriteLine($"PS5 specs:\n\tPower: {ps5.Power}\n\tWeight: {ps5.Weight}");
        }

    }
}