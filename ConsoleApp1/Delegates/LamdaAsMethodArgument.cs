using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class LamdaAsMethodArgument
    {
        public static void ExecuteLamdaAsMethodArgument(Func<int,int> operation, int number, string message)
        {
            int result = operation(number);
            Console.WriteLine(message + result);
        }

        public static void ExecuteValidation(Predicate<string> validation,string value,string message)
        {
            string result = (validation(value)?"Valid":"Invalid");
            Console.WriteLine(message + result);
        }

        public static void ExecuteValidationn(Predicate<string> validation, string value)
        {
            Console.WriteLine("Validation Started");


            bool result = validation(value);
            Console.WriteLine($"{value}  {(result ? "Customer is Valid" : "Customer is Invalid")}");

            Console.WriteLine("Validation Completed");
            Console.WriteLine();

        }

        public static Func<decimal,bool> CreateTrxValidator(decimal minAmount)
        {
            return amount => amount >= minAmount;
        }

        
    }
}
