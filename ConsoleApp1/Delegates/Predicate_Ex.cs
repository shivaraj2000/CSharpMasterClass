using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Predicate_Ex
    {
        public static bool IsPassed(int x)
        {
            return (x >= 40)? true : false;
        }

        public static void ExecuteBoolCheck(Predicate<int> predicate,int x)
        {
            bool isPassed= predicate(x);
            string messsage = (isPassed) ? "Passed" : "Failed";
            Console.WriteLine($"Student with marks {x} is {messsage}");
        }
    }
}
