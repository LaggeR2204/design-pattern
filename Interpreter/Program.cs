using System;

namespace InterpreterDemo
{
    interface Expression
    {
        string interpreter(InterpreterContext con);
    }

    class InterpreterContext
    {
        public String getBinaryFormat(int val)
        {
            return Convert.ToString(val, 2);
        }

        public String getHexFormat(int val)
        {
            return val.ToString("X");
        }
    }

    class IntToHexExpression : Expression
    {
        int val;

        public IntToHexExpression(int value)
        {
            this.val = value;
        }

        public string interpreter(InterpreterContext ctx)
        {
            return ctx.getHexFormat(val);
        }
    }

    class IntToBinaryExpression : Expression
    {
        int val;

        public IntToBinaryExpression(int value)
        {
            this.val = value;
        }

        public string interpreter(InterpreterContext ctx)
        {
            return ctx.getBinaryFormat(val);
        }
    }

    // Driver class
    class Program
    {

        static void Main(string[] args)
        {
            string input = "224 in binary";
            if (input.Contains("binary"))
            {
                int val = int.Parse(input.Split(" ")[0]);
                Console.WriteLine(val + " in binary is " + new IntToBinaryExpression(val).interpreter(new InterpreterContext()));
            }

            input = "224 in hexadecimal";
            if (input.Contains("hexadecimal"))
            {
                int val = int.Parse(input.Split(" ")[0]);
                Console.WriteLine(val + " in hexadecimal is " + new IntToHexExpression(val).interpreter(new InterpreterContext()));
            }

        }
    }

}