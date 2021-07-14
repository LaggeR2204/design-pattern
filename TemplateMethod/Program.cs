using System;

namespace TemplateMethodDemo
{
    abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built.");
        }

        protected void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement,iron rodsand sand");
        }

        protected abstract void BuildPillars();

        protected abstract void BuildWalls();

        protected void BuildWindows()
        {
            Console.WriteLine("Building Glass Windows");
        }
    }

    class GlassHouse : HouseTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Glass Walls");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building Pillars with glass coating");
        }
    }

    class WoodenHouse : HouseTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Wooden Walls");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building Pillars with Wood coating");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HouseTemplate woodenHouse = new WoodenHouse();
            woodenHouse.BuildHouse();
            Console.WriteLine("-------------------------");
            HouseTemplate glassHouse = new GlassHouse();
            glassHouse.BuildHouse();
        }
    }
}
