using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Func_Example
    {
        public static double CalculateAddition(int x, double y)
        {
            return x + y;
        }

        public static double CalculateSubtraction(int x, double y)
        {
            return x - y;
        }
        public static double CalculateMultiplication(int x, double y)
        {
            return x * y;
        }

        public static void ExecuteTests(Func<int, double,double>fun,int a,double b, string message)
        {
            double x=fun(a,b);
            Console.WriteLine($"{message} {x}");
        }
    }
}
