using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Context
    {
        private SortStrategy _strategy;

        public Context()
        { }

        public Context(SortStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(SortStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeLogic(string s)
        {
            List<char> temp = new List<char>();
            foreach (char c in s)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    temp.Add(c);
                }
            }
            Console.WriteLine("Sorting data using the sort_strategy");
            var result = this._strategy.Sort(temp);

            string resultStr = string.Empty;
            foreach (var element in result as List<char>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}