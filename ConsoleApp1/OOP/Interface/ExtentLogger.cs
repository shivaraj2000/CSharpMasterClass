using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Interface
{
    internal class ExtentLogger:ITestLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log {message}");
        }
    }
}
