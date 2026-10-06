using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class Gnereiucs_RefType<T> where T: class
    {
        public void CalculateLength(T value)
        {
            Console.WriteLine(value);
        }
    }
}
