using ConsoleApp1.OOP.Interface;

namespace ConsoleApp1.OOP.Abstraction
{
    public class PaymentTest : BaseTest, IDataBaseValidator, ITestLogger
    {
        public override void ExecuteTest(string message)
        {
            Console.WriteLine("Executing the payment test");
        }

        public void ValidateDatabase(string query)
        {
            Console.WriteLine($"Executing paymentQuery : {query}");
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logs are generated for payment as :  {message}");
        }
    }



}
