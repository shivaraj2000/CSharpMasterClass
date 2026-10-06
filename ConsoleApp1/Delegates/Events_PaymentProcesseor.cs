using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Events_PaymentProcesseor
    {
        public delegate void TestAction();

        public event TestAction PaymentCompleted;

      
        public void ProcessPayment()
        {
            Console.WriteLine("Payment Processing...");
            Console.WriteLine("Payment Completed");

            PaymentCompleted?.Invoke();
        }

        public  void LogPayment()
        {
            Console.WriteLine("Paymnet Logged");
        }

        public  void SendNotification()
        {
            Console.WriteLine("Notification Sent");
        }

        public
            void GenerateReceipt()
        {
            Console.WriteLine("Receipt Generated");
        }
    }
}
