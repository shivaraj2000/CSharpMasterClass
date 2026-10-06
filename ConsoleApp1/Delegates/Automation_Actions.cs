using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Automation_Actions
    {
        public static void Login()
        {
            Console.WriteLine("Login Executed");
        }

        public static void TakeScreenshot()
        {
            Console.WriteLine("Screenshot Taken");
        }

        public static void Logout()
        {
            Console.WriteLine("Logout Executed");
        }

        public static void ExecuteAction(Action action)
        {
            Console.WriteLine("Exectuion Started");
            action();
            Console.WriteLine("Exceution Completed");
        }

        public static void LogTest(string testCaseName, int testCaseID)
        {
            Console.WriteLine("Executing " + testCaseName + " with TestCaseID as " + testCaseID);
        }

        public static void ExecuteTest(Action<string,int> a,string message, int code)
        {
                a(message, code);
        }

        public static void LogStatus(string status, int statusCode)
        {
            Console.WriteLine($"TestCase Status is {status} with status code as {statusCode}");
        }

    }
}
