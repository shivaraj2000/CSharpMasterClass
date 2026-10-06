using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal interface IGenericInterface<T>
    {
        void Validation(T Data);
    }

    public class Transaction
    {
        public string TrxID { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransactionValidator : IGenericInterface<Transaction>
    {
        public void Validation(Transaction data)
        {
            Console.WriteLine($"Transacion ID : {data.TrxID}");
            Console.WriteLine($"Amout : {data.Amount}");
            Console.WriteLine("Transaction Validation Completed");
        }
    }

    public class AmountValidator : IGenericInterface<decimal>
    {
        public void Validation(decimal amount)
        {
            if(amount>=10000)
                Console.WriteLine($" {amount} is High Value");
            else
                Console.WriteLine($" {amount} is Normal Value");
        }
    }
}
