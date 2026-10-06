using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Collections
{
    internal class Stack
    {
        public static void StackExample()
        {
            Stack<string> transactions = new();

            transactions.Push("TX001");
            transactions.Push("TX002");
            transactions.Push("TX003");
            transactions.Push("TX004");
            transactions.Push("TX005");

            Console.WriteLine("Before Pop the count is " + transactions.Count);

            if (transactions.TryPeek(out string transaction))
                Console.WriteLine("Top Transaction is " + transaction);
            else
                Console.WriteLine("Stack is Empty");


            while(transactions.TryPop(out string trx))
                Console.WriteLine("Processing : " + trx);

            Console.WriteLine("After Pop the count is " + transactions.Count);
                
        }
    }
}
