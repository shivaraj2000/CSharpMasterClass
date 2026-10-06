using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class TAsStruct
    {
        public static void ProcessVal<T>(T data)
            where T : struct
        {
            Console.WriteLine($"value is {data}");
        }

    }
}
