using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class Method_Overriding_Bike : Method_Overriding_Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike Started");
        }
    }
}
