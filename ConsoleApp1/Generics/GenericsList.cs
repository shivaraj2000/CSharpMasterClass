namespace ConsoleApp1.Generics
{
    internal class GenericsList
    {
        public static void TrxList()
        {
            List<decimal> transactionAmounts = new List<decimal>();
            transactionAmounts.Add(5000);
            transactionAmounts.Add(12000);
            transactionAmounts.AddRange(new List<decimal> { 7500, 25000, 3000 });

            foreach (decimal amount in transactionAmounts)
            {
                Console.Write(amount + " ");
            }
            Console.WriteLine();
            Console.WriteLine(transactionAmounts.Count);
            Console.WriteLine((transactionAmounts.Contains(12000) ? "12k is presnet" : "12k is not present"));
            transactionAmounts.Remove(7500);
            foreach (decimal amount in transactionAmounts)
            {
                Console.Write(amount + " ");
            }
            Console.WriteLine();
            Console.WriteLine(transactionAmounts.Count);
        }
    }
}
