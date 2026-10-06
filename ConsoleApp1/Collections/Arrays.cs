using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1.Collections
{
    internal class Arrays
    {
        public  static void ProcessTransactions()
        {
            int[] transactions = { 5000, 12000, 7500, 25000, 3000, 18000 };
            int TotalAmount = 0;
            int TrxCountGreaterThan10k = 0;
            int HighestTrxAmount = int.MinValue;

            Console.Write("All elements in array are : ");
            for(int i=0;i<transactions.Length;i++)
            {
                TotalAmount+= transactions[i];
                Console.Write(transactions[i] + " ");
                if (transactions[i]>10000)
                {
                    TrxCountGreaterThan10k++;   
                }    
                if(transactions[i]>HighestTrxAmount)
                {
                    HighestTrxAmount=transactions[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total Amount is " + TotalAmount);
            Console.WriteLine("Trx count greater than 10k is "+ TrxCountGreaterThan10k );
            Console.WriteLine("Highest Trx Amount is " + HighestTrxAmount);

        }

        public static void MultiDimesnosalArrays()
        {
            int[,] transactions ={{ 5000, 12000, 7500 },{ 25000, 3000, 18000 },{ 9000, 15000, 22000 } };
            int TotalAmount = 0;
            int MaxAmount = int.MinValue;
            int TrxGretaretThan10k = 0;
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < transactions.GetLength(0); i++)
            {
                for (int j = 0; j < transactions.GetLength(1); j++)
                {
                    Console.Write(transactions[i,j] + " ");
                    TotalAmount += transactions[i, j];
                    if (transactions[i,j]>MaxAmount)
                    {
                        MaxAmount= transactions[i,j];
                    }
                    if (transactions[i,j]>10000)
                    {
                        TrxGretaretThan10k++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total Amount is " + TotalAmount);
            Console.WriteLine("Max Amount is " + MaxAmount);
            Console.WriteLine("Trx Greater Than 10K Count is " + TrxGretaretThan10k);
        }


        public static void ArrayProblems()
        {
            int[] transactions = { 5000, 12000, 7500, 25000, 3000, 18000, 12000, 4500, 30000, 8000 };
            int TotalTrxAmount = 0;
            int HightestTrxAmount = int.MinValue;
            int LowestTrxAmount = int.MaxValue;
            int TrxCountGreater10K = 0;
            int k12Appers = 0;


            Console.WriteLine("All Transactions are : ");
            for (int i = 0; i < transactions.Length; i++)
            {
                Console.Write(transactions[i] + " ");
                TotalTrxAmount += transactions[i];
                if (transactions[i] > HightestTrxAmount)
                    HightestTrxAmount= transactions[i];
                if (transactions[i] < LowestTrxAmount)
                    LowestTrxAmount = transactions[i];
                if (transactions[i] > 10000)
                    TrxCountGreater10K++;
                if (transactions[i]==12000)
                    k12Appers++;    

            }

            int greaterThan20k = Array.Find(transactions, amount => amount > 20000);

            Console.WriteLine("Total Trx Amount is " + TotalTrxAmount);
            Console.WriteLine("Highest Trx Amount is " + HightestTrxAmount);
            Console.WriteLine("Lowest Trx Amount is " + LowestTrxAmount);
            Console.WriteLine("Trx Count Greater than 10k is " + TrxCountGreater10K);
            Console.WriteLine("Trx Equal to 12k count is " + k12Appers);
            Console.WriteLine("Avg Transaction Amount is " + (TotalTrxAmount/transactions.Length));
            Console.WriteLine("First Trx Greater than 20k is " + greaterThan20k);
        }
    }

}

