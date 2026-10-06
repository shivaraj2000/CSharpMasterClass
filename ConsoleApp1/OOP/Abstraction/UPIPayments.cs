using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstraction
{
    public class UPIPayments:Payments
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing UPI Payments");
        }
    }
}
