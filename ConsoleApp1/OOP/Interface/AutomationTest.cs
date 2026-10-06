using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Interface
{
    internal class AutomationTest:IDataBaseValidator,ITestLogger,ITestReporter
    {
        public void Log(string log)
        {
            Console.WriteLine($"LOG: {log}");
        }

        public void GenerateReport(string reportName)
        {
            Console.WriteLine($"REPORT GENERATED FOR: {reportName}");
        }

        public void ValidateDatabase(string query)
        {
            Console.WriteLine($"VALIDATING DATABASE USING: {query}");
        }
    }
}
