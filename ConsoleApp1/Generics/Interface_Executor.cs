using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class Interface_Executor
    { 
        public static void ExecuteInterface<T>(T test)
            where T:Interface_Generics
        {
            Console.WriteLine("Validation Started");
            test.Validate();
            Console.WriteLine("Validation Completed");
        }
    }
}
