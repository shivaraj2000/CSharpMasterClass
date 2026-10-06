using ConsoleApp1.OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstraction
{
    public class LoginTest:BaseTest, IDataBaseValidator,ITestLogger
    {
        public override void ExecuteTest(string message)
        {
            Console.WriteLine("Executing the login test");
        }

        public void ValidateDatabase(string query)
        {
            Console.WriteLine($"Executing login Query : {query}");
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logs are generated for login as :  {message}");
        }
    }
}
