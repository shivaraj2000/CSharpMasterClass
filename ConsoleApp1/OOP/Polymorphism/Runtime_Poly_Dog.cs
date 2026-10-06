using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class Runtime_Poly_Dog:Runtime_Poly_Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }

        public  void Bark()
        {
            Console.WriteLine("Dog will bark");
        }
    }
}
