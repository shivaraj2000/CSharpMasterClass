using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class Method_Overriding_Car : Method_Overriding_Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Started");
        }
    }
}
