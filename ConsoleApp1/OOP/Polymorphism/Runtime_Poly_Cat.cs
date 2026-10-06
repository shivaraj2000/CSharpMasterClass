using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class Runtime_Poly_Cat:Runtime_Poly_Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void Meow()
        {
            Console.WriteLine("Cat will Meow");
        }
    }
}
