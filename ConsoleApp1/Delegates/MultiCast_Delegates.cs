using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Delegates
{
    internal class MultiCast_Delegates
    {
        public static void SetupTest()
        {
            Console.WriteLine("Test Setup Started");
        }

        public static void ValidateTransaction()
        {
            Console.WriteLine("Transaction Validation Completed");
        }

        public static void GenerateReport()
        {
            Console.WriteLine("Report Generated");
        }

        public static void Cleanup()
        {
            Console.WriteLine("Test Cleanup Completed");
        }

        public static void SendNotification()
        {
            Console.WriteLine("Notification Sent");
        }

        public static void ExecuteMultiCaseDelegates()
        {
            Action testLifeCycle = SetupTest;
            testLifeCycle += ValidateTransaction;
            testLifeCycle += GenerateReport;
            testLifeCycle += Cleanup;
            testLifeCycle -= GenerateReport;
            testLifeCycle += SendNotification;

            testLifeCycle();
        }




    }
}
