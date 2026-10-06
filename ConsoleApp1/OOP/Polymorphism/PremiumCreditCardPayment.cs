using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class PremiumCreditCardPayment:CreditCardPayment
    {
        public override void ProcessPayment()
        {
            base.ProcessPayment();
            Console.WriteLine("Processing Premium Credit Card Payment");
        }
    }
}
