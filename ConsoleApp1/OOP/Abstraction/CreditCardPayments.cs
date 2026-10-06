using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstraction
{
    public  class CreditCardPayments:Payments
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Credit Card Payemnet");
        }
        public void Pay()
        {
            Console.WriteLine("Do the pay");
        }
    }
}
