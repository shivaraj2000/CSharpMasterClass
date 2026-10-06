using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class EventHandlerWithParams
    {
        public event EventHandler<PaymentCompletedEventsArgs> PaymentCompleted;

        public void ProcessPayment()
        {
            Console.WriteLine("Processing Payment");
            string transactionID = "Trx120";
            decimal amount = 100.45M;
            string status = "Approed";
            Console.WriteLine("Payment Completed");

            PaymentCompleted?.Invoke(this , new PaymentCompletedEventsArgs(transactionID,amount,status));
        }

        public void LogPayment(object sender, PaymentCompletedEventsArgs e)
        {
            Console.WriteLine($"Transaction ID {e.TransactionId}" );
            Console.WriteLine($"Amount {e.Amount}");
            Console.WriteLine($"Status {e.Status}");
        }
    }
}
