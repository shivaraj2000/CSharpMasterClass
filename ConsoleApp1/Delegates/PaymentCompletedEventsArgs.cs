using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class PaymentCompletedEventsArgs:EventArgs
    {
        public string TransactionId { get; }
        public decimal Amount { get; }

        public string Status { get; }

        public PaymentCompletedEventsArgs(string transactionId, decimal amount, string status)
        {
            TransactionId = transactionId;
            Amount = amount;
            Status = status;

        }


    }
}
