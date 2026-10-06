using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCProjoect.Basics
{
    internal class Arrays
    {

        public void arrayDemo()
        {
            int[] n = new int[5];

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Enter a Number : ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();
            foreach (int nn in n)
            {
                Console.Write(nn + " ");
            }
            Console.WriteLine();

            int[] m = { 5, 345, 6, 7, 8, 6 };
            foreach (int mm in m)
            {
                Console.Write(mm + " ");
            }
        }

        public void isTriangleValid()
        {
            int[] angles = new int[3];


            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write("Enter the angles : ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            int totalsum = 0;
            for (int i = 0; i < angles.Length; i++)
            {
                totalsum += angles[i];
            }

            string res = ((totalsum == 180) ? "Valid" : "NotValid");
            Console.WriteLine(res);

        }

        public void sortArray()
        {
            int[] n = new int[] { 3, 5, 1, 2, 6, 7, 8, 5 };
            //Array.Sort(n);

            //foreach(int nn in n)
            //    {
            //    Console.Write(nn + " ");
            //}

            for (int i = 0; i < n.Length - 1; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] > n[j])
                    {
                        int tmp = n[j];
                        n[j] = n[i];
                        n[i] = tmp;
                    }
                }
            }

            foreach (int nn in n)
            {
                Console.Write(nn + " ");
            }
        }

        public void reverseArray()
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 0 };

            Array.Reverse(a);
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            //Console.WriteLine();
            //for(int i=a.Length-1;i>=0;i--)
            //{
            //    Console.Write(a[i] + " ");
            //}
        }

        public void clearingArray()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Array.Clear(a, 0, a.Length);
            Array.Clear(a, 3, 3);

            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        public void indexOfArray()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.Write("Enter the number to search : ");
            int num = Convert.ToInt32(Console.ReadLine());

            //int pos=Array.IndexOf(a, num);
            //int pos = Array.IndexOf(a, num,5);
            int pos = Array.IndexOf(a, num, 4, 2);


            if (pos > -1)
                Console.WriteLine($"Number {num} is present at position {pos + 1}");
            else
                Console.WriteLine($"Number {num} is not found");


        }

        public void list()
        {
            List<int> lists = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                lists.Add(i);
            }



            lists.Remove(1);
            lists.Insert(2, 33);

            lists.Sort();
            lists.Reverse();
            lists.Contains(9);
            lists.RemoveAt(0);

            foreach (int ch in lists)
            {
                Console.Write(ch + " ");
            }
        }
    }
}