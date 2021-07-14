using System;

namespace DemoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(10);
            RoundPeg rpeg = new RoundPeg(10);
            
            Console.Write("Check RoundPeg: ");
            Console.WriteLine(hole.fits(rpeg));

            SquarePeg sqPeg = new SquarePeg(5);
            PegAdapter adapter = new PegAdapter(sqPeg);

            Console.Write("Check SquarePeg: ");
            Console.WriteLine(hole.fits(adapter));
            Console.Read();
        }
    }
}
