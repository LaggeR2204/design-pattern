using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class NormalSort : SortStrategy
    {
        public object Sort(object data)
        {
            var list = data as List<char>;

            list.Sort();

            return list;
        }
    }

    class ReverseSort : SortStrategy
    {
        public object Sort(object data)
        {
            var list = data as List<char>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Strategy is set to normal sorting.");
            context.SetStrategy(new NormalSort());
            context.DoSomeLogic("Binh Dep Trai Thuc Su");

            Console.WriteLine();

            Console.WriteLine("Strategy is set to reverse sorting.");
            context.SetStrategy(new ReverseSort());
            context.DoSomeLogic("Binh Dep Trai Thuc Su");

            Console.Read();
        }
    }
}