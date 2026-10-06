using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Delegate_Ex
    {

        public delegate void Calulator(int a, int b);

        public static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divison(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public static void ExecuteOperation(Calulator calulator)
        {
            calulator(10, 20);
        }

    }
}
