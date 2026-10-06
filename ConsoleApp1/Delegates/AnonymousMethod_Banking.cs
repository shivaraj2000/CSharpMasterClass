using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class AnonymousMethod_Banking
    {
        public static void ExecuteAnonymousMethod(string m,decimal a, string status)
        {
            Action<string> log = delegate (string message)
            {
                Console.WriteLine($"LOG : {message}");
            };

            Func<decimal, bool> checkAmount = delegate (decimal amount)
            {
                 //return (amount >= 10000) ? true : false;
                 return amount >= 10000;
            };

            Predicate<string> checkStatus = delegate (string status)
            {
               return status == "Approved";
            };

            

            log(m);


            if (checkAmount(a))
                Console.WriteLine($"{a} is High Value");
            else
                Console.WriteLine($"{a} is Normal Value");

            if(checkStatus(status))
                Console.WriteLine($"Transaction status {status} is Valid");
            else
                Console.WriteLine($"Transaction status {status} is InValid");
            Console.WriteLine();



        }
       

       
    }
}
