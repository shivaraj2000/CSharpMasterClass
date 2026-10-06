using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class Generaics_Basics
    {
        public static void printValue<T>(T value)
        {
            Console.WriteLine($"Type is {value.GetType()?.Name} or {typeof(T).Name} and it's value is {value}");
        }

        public static void printTrx<T1,T2>(T1 id, T2 amount)
        {
            Console.WriteLine($"{typeof(T1).Name} --> {id}");
            Console.WriteLine($"{typeof(T2).Name} --> {amount}");
        }


    }
}
