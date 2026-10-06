using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Collections
{
    internal class Queue
    {
        public static void QueueExample()
        {
            Queue<string> Transactions = new();
            Transactions.Enqueue("TX001");
            Transactions.Enqueue("TX002");
            Transactions.Enqueue("TX003");
            Transactions.Enqueue("TX004");
            Transactions.Enqueue("TX005");

            Console.WriteLine("Length Before Dequeue " + Transactions.Count);

            while (Transactions.Count > 0)
            {
                if (Transactions.TryDequeue(out string trxID))
                {
                    Console.Write($"Processing : {trxID}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Length After Dequeue " + Transactions.Count);

        }
    }
}
