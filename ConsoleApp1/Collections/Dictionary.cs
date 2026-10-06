namespace ConsoleApp1.Collections
{
    public class Transactions
    {
        public string TransactionID { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }

    internal class Dictionary
    {
        public static void ProcessTrxs()
        {
            List<Transactions> trxList = new List<Transactions>
            {
                new Transactions { TransactionID = "TX001", Amount = 15000, Status = "Approved" },
                new Transactions { TransactionID = "TX002", Amount = 5000, Status = "Failed" },
                new Transactions { TransactionID = "TX003", Amount = 50000, Status = "Pending" },
                new Transactions { TransactionID = "TX004", Amount = 8000, Status = "Approved" },
                new Transactions { TransactionID = "TX005", Amount = 18000, Status = "Approved" }
            };

            Dictionary<String, Transactions> dict = new Dictionary<string, Transactions>();

            foreach (Transactions trx in trxList)
            {
                dict.Add(trx.TransactionID, trx);
            }

            foreach(var trx in dict)
            {
                Console.WriteLine($"{trx.Key} - {trx.Value.Amount} - {trx.Value.Status}");
            }

            if(dict.ContainsKey("TX003"))
                Console.WriteLine("TX003 Amount: " + dict["TX003"].Amount);

            dict["TX002"].Status = "Approved";

            dict.Add("TX006", new Transactions {TransactionID="TX006", Amount=34000, Status="Approved" });
            dict["TX007"] = new Transactions { TransactionID="TX007", Amount=7000, Status="Approved" };

            dict.Remove("TX001");

            int count = 0;
            foreach(var trx in dict)
            {
                if (trx.Value.Amount > 20000)
                    count++;
       
            }
            Console.WriteLine($"{count} Transactions are greater than 20k");

            Console.WriteLine(dict.ContainsKey("TX007"));
            if(dict.TryGetValue("TX005",out Transactions trxs))
                Console.WriteLine(trxs.Amount);
         
            foreach(var trx in dict)
            {
                Console.WriteLine($"{trx.Value.TransactionID} - {trx.Value.Amount} - {trx.Value.Status}");
            }
        }

      
    }
}
