using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class CreditCardPayment:Payment
    {
        public override void ProcessPayment()
        {
            base.ProcessPayment();
            Console.WriteLine("Processing Credit Card Payment");
        }
    }
}
