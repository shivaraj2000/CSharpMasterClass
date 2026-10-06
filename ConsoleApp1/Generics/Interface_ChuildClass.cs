namespace ConsoleApp1.Generics
{
    internal class Interface_ChuildClass
    {
        public class UIValidation : Interface_Generics
        {
            public void Validate()
            {
                Console.WriteLine("UI Validated");
            }
        }

        public class DBValidation : Interface_Generics
        {
            public void Validate()
            {
                Console.WriteLine("UI Validated");
            }
        }

        public class APIValidation : Interface_Generics
        {
            public void Validate()
            {
                Console.WriteLine("UI Validated");
            }
        }
     
    }
}

