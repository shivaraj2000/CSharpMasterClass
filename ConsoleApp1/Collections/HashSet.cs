using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Collections
{
    internal class HashSet
    {
        public static void HashSetEx()
        {
            string[] TrxIds =  {"TX001","TX002", "TX003", "TX002", "TX004", "TX001", "TX005", "TX003", "TX006" };

            HashSet<string> trxID = new HashSet<string>();
            foreach(string TrxId in TrxIds)
            {
                trxID.Add(TrxId);
            }

            foreach(string trx in trxID)
            {
                Console.Write (trx + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total Count is " + trxID.Count);
            Console.WriteLine(trxID.Contains("TX003")?"TX003 is present":"TX003 is not present");
            trxID.Remove("TX004");
            Console.WriteLine("New Count is " + trxID.Count);

            HashSet<string> Expected = new() { "TX001", "TX002", "TX003", "TX005", "TX006" };
            Console.WriteLine(trxID.SetEquals(Expected)?"Current and Expected Sets are Same" : "Current and Expected Sets are diffrent");

            trxID.Add("TX007");
            trxID.Add("TX008");


            
            HashSet<string> SystemB = new() { "TX006", "TX007", "TX009" };
            HashSet<string> CommonIDs = new(trxID);
            CommonIDs.IntersectWith(SystemB);

            foreach(string t in CommonIDs)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();


            HashSet<string> ExceptWithIDs = new(trxID);
            ExceptWithIDs.ExceptWith(SystemB);
            foreach(string t in ExceptWithIDs)
            {
                Console.Write(t + " ");
            }
        }
    }
}
