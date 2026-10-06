using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Events_EventHandler_PaytmentProcess
    {
        public event EventHandler PaymentCompleted;

        public  void ProcessPayment()
        {
            Console.WriteLine("Payment Completed");
            PaymentCompleted?.Invoke(this,EventArgs.Empty);
        }

        public void Login(object sender,EventArgs e)
        {
            Console.WriteLine("Login Completed");
        }
    }
}
