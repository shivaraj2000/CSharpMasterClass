using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp1.Delegates
{
    internal class Lamda_Opretator
    {
        public static void lamdaExcercise()
        {
            Action<string> action = delegate (string message)
            {
                Console.WriteLine(message); 
            };

            Action<string> action1 = (string message) =>
            {
                Console.WriteLine(message);
            };

            Action<string> action2 = message =>
            {
                Console.WriteLine(message);
            };

            Action<string> action3 = message => Console.WriteLine(message);

            Action<string, int> action4 = (testcaseName, testcaseID) => 
                Console.WriteLine($"{testcaseName} test with testcase id as {testcaseID} is currently executing");

            Func<int,int,int> addition = (a,b) => (a + b);
            Func<int, int, int> subtraction = (a, b) =>
            {
                return a - b;
            };

            Predicate<int> checkMarks = marks => (marks >= 40);

            Func<int, int, int> opertn = (a, b) => (a * b + 10);

            action("Test Message");
            action1("Test Message 1");
            action2("Test Message 2");
            action3("Test Message 3");
            action4("Login", 101);

            int res1=addition(3, 4);
            Console.WriteLine($"Addition : {res1}");
            Console.WriteLine($"Subtraction : {subtraction(10, 3)}");

            Console.WriteLine($"Student with 35 marks is {(checkMarks(35)?"Pass":"Fail")}ed");
            Console.WriteLine($"Student with 75 marks is {(checkMarks(75) ? "Pass" : "Fail")}ed");

            Func<int, int> calculate = x => x + 5;

            Console.WriteLine($"Addition of 5 and 5 is {calculate(5)}");
            Console.WriteLine($"Addition of 11 and 5 is {calculate(11)}");

            Console.WriteLine($"Opertion Res of 2,5 is {opertn(2, 5)} ");
            Console.WriteLine($"Opertion Res of 4,3 is {opertn(4, 3)} ");



        }
    }
}
