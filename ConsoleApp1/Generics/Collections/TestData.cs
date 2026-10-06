using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics.Collections
{
    public class TestData<T>
    {
        public T Data { get; set; }


        public static void Show(T data)
        {
            Console.WriteLine(data);
        }

    }

    public class TestDatas<T>
    {
        public void Show(T data)
        {
            Console.WriteLine(data);
        }

        public void Print<U>(U data)
        {
            Console.WriteLine(data);
        }
    }

}
