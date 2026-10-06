using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCProjoect.Basics
{
    public class Operators
    {
        //int
        public void DataTypes()
        {
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            //long
            long ageLong = 23L;
            Console.WriteLine(ageLong);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            //double
            double ageDouble = 23.23452D;
            Console.WriteLine(ageDouble);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //float
            float ageFloat = 23.23452F;
            Console.WriteLine(ageDouble);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            //decimal
            decimal agedecimal = 23.23452M;
            Console.WriteLine(ageDouble);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //Convert String to Int
            string string1 = "45";
            int int1 = Convert.ToInt32(string1);
            long long1 = Convert.ToInt64(string1);
            Double doubl1 = Convert.ToDouble(string1);
            float float1 = Convert.ToInt32(string1);
            decimal decimal1 = Convert.ToInt32(string1);


            Console.WriteLine(int1);

            Console.ReadLine();
        }
    }
}