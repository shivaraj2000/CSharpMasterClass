using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class Payment
    {
        public virtual void ProcessPayment()
        {

            Console.WriteLine("Validating Payment");
        }
    }
}
