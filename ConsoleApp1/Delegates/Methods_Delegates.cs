using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates
{
    internal class Methods_Delegates
    {
        public delegate void ValidateAction();
        public  void UIValidation()
        {
            Console.WriteLine("UI Validation Executed");
        }

        public  void APIValidation()
        {
            Console.WriteLine("API Validation Executed");
        }

        public void DataBaseValidation()
        {
            Console.WriteLine("DataBase Validation Executed");
        }

        public void ExecuteValidation(ValidateAction test)
        {
            Console.WriteLine("Validation Started");
            test();
            Console.WriteLine("Validation Completed");
        }
    }
}
