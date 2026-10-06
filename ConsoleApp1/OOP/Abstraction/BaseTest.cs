using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstraction
{
    public abstract class BaseTest
    {
        public void SetUp(string message)
        {
            Console.WriteLine($"Setting Up {message} Test");
        }

        public abstract void ExecuteTest(string message);
    }
}
