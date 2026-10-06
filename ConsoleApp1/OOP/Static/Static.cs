using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Static
{
    public class Static
    {
        public string BankName = "ABC Bank";
        public static void ShowBankName()
        {
            Static s1 = new Static();
            Console.WriteLine(s1.BankName);
        }

        public static string BankNames = "ABC Banks";

        public static void ShowBankNames()
        {
            Console.WriteLine(BankNames);
        }

        public string BankNam = "ABC Ban";

        public void ShowBankNam()
        {
            Console.WriteLine(BankNam);
        }

        public static string BName = "ICICI";
        public string AName = "Shiva";
        public void IndianBank()
        {
            Console.WriteLine(BName);
            Console.WriteLine(AName);
        }
    }
}
