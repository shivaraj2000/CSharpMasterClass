using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCProjoect.Basics
{
    internal class Loops
    {
        public void dict()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(2, "Test2");
            names.Add(3, "Test3");
            names.Add(1, "Test1");


            for (int i = 0; i < names.Count; i++)
            {
                //Console.WriteLine(names.ElementAt(i));
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");

            }

            Console.WriteLine();

            if (names.ContainsKey(3))
            {
                names.Remove(3);
            }

            names.Add(3, "Added3Back");
            names[2] = "Test2Updated";


            foreach (KeyValuePair<int, string> pair in names)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            if (names.TryGetValue(4, out string val))
            {
                Console.WriteLine($"val is present for key as {val}");
            }
            else
                Console.WriteLine($"val is not present for serached key");

        }

        public void oddEvenUsingList()
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    even.Add(i);
                else
                    odd.Add(i);
            }

            Console.WriteLine("Even numbers are : ");
            foreach (var n in even)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers are : ");
            foreach (var n in odd)
            {
                Console.Write(n + " ");
            }
        }

        public static void arayyMultiple()
        {
            int num = 7;
            int length = 5;
            int[] a = new int[length];
            int counter = 0;

            for (int i = 1; i <= a.Length; i++, counter++)
            {
                a[counter] = i * num;
            }

            foreach (int n in a)
            {
                Console.Write($"{n} ");
            }
        }

        public void functionWithNoPramNoReturn()
        {
            Console.WriteLine("Hello Programming");
        }

        public void functionWithPramNoReturn(string name)
        {
            Console.WriteLine(name);
        }

        public int functionWithNoPramReturn()
        {
            return 10 + 20;
        }

        public int functionWithPramReturn(int a, int b, int c)
        {
            return a + b + c;
        }

        //public void optionalParamters(int a, int b = default)
        //public void optionalParamters(int a, [Optional] int b)
        public void optionalParamters(int a, int b = 50)
        {
            Console.WriteLine(a + b);
        }

        public void namedParameters(String Name, int age, String Address)
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"Address : {Address}");
        }

        public void outParameters(out int num)
        {
            num = 5;
        }

        public bool outParatmerter2(string name, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(name.ToLower()))
                {
                    index = i;
                }
            }
            if (index > -1)
                return true;
            else
                return false;

        }

        public void refParatmeters(ref int x)
        {
            x = x * 2;
        }

        public static void calcArea()
        {
            int height = ReadInt("Enter the height : ");
            int width = ReadInt("Enter the width : ");

            Console.WriteLine($"Area for given height {height} and width {width} is {area(height, width)}");
        }

        static int area(int h, int w)
        {
            return (h * w) / 2;
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }



    }
}