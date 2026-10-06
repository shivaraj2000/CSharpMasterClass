using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Collections.List
{
    internal class List_Basics
    {
        public static void BasicList()
        {
            List<decimal> transactionAmounts = new List<decimal>();
            transactionAmounts.Add(5000);
            transactionAmounts.Add(12000);
            transactionAmounts.AddRange(new List<decimal> { 7500, 25000, 3000 });

            foreach (decimal amount in transactionAmounts)
            {
                Console.Write(amount + " ");
            }
            Console.WriteLine();
            Console.WriteLine(transactionAmounts.Count);
            Console.WriteLine((transactionAmounts.Contains(12000) ? "12k is presnet" : "12k is not present"));
            transactionAmounts.Remove(7500);
            foreach (decimal amount in transactionAmounts)
            {
                Console.Write(amount + " ");
            }
            Console.WriteLine();
            Console.WriteLine(transactionAmounts.Count);
        }

        public static void ProcessTransactionList()
        {
            List<decimal> TransactionAmount = new List<decimal> { 5000, 12000, 7500, 25000, 3000, 18000, 12000 };
            decimal HighestAmount = int.MinValue;
            decimal LowestAmount = int.MaxValue;
            decimal TrxGreater15k = TransactionAmount.Find(x=>x>15000);
            List<decimal> TrxGreaterThan10k = new();

            Console.Write("All Transactions Amounts are : ");
            for (int i = 0; i < TransactionAmount.Count; i++)
            {
                Console.Write(TransactionAmount[i] + " ");
                if (TransactionAmount[i] > HighestAmount)
                    HighestAmount = TransactionAmount[i];
                if (TransactionAmount[i] < LowestAmount)
                    LowestAmount = TransactionAmount[i];
               
                if (TransactionAmount[i]>10000)
                {
                    TrxGreaterThan10k.Add(TransactionAmount[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total Count of Trx is " + TransactionAmount.Count);
            TransactionAmount.Add(3000);
            TransactionAmount.Insert(2, 10000);
            TransactionAmount.Remove(12000);
            bool Exists25k = TransactionAmount.Contains(25000);
            Console.WriteLine("25k is found : " + Exists25k);
            Console.WriteLine("First Trx greater than 15k are ");

            foreach (decimal i in TrxGreaterThan10k)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            TransactionAmount.Sort();
            TransactionAmount.Reverse();
            Console.WriteLine("After Sorting and Reversing ");
            foreach(decimal i in TransactionAmount)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }

        public static void CapacityCount()
        {
            List<int> transactions = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                transactions.Add(i);

                Console.WriteLine(
                    $"Added: {i} | Count: {transactions.Count} | Capacity: {transactions.Capacity}");
            }
        }


    }
}
