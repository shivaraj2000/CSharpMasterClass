using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstraction
{
    public abstract class Payments
    {
        public abstract void ProcessPayment();

        public void ValidatePayment()
        {
            Console.WriteLine("Validating Payment");
        }

     
    }
}
