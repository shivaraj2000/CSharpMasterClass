using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    public class BaseTest_ICI
    {
        public void Setup()
        {
            Console.WriteLine("Set up completed");
        }
    }

    public interface ITestLogget
    {
        void Logeer();
    }

    public class PaymentTests : BaseTest_ICI, ITestLogget
    {
        public PaymentTests()
        {
            Console.WriteLine("Payment Contructor Started");
        }
        public void Logeer()
        {
            Console.WriteLine("Logging Completed");
        }

    }

    public class Exceutor
    {
        public static void Exceutors<T>()
            where T : BaseTest_ICI, ITestLogget, new()
        {
            T test = new T();
            test.Setup();
            test.Logeer();
         }
    }

}
