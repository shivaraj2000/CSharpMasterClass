using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    public class MethodOverloading
    {
        public void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition of two no is "+ sum);
        }

        public void Add(int x, int y, int z)
        {
            int sum=x + y + z;
            Console.WriteLine("Addition of three no is " + sum);
        }

        public void Add(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Addition of two decimal no is " + sum);
        }

        public void Add(string  x, string y)
        {
            Console.WriteLine($"Given Strings are {x} and {y}");
        }



    }
}
