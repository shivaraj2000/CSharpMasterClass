using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics.Collections
{
    internal class HandsOn
    {
    }

    public abstract class BaseTestt
    {
        public void SetUp()
        {
            Console.WriteLine("Setup Completed");
        }
        public abstract void Execute();
    }

    public interface ITestLoggerr
    {
        void Log(string message);
    }

    public class LoginTestt : BaseTestt, ITestLoggerr
    {
        public LoginTestt()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public override void Execute()
        {
            Console.WriteLine("Login Test Started");
        }
    }

    public class TestRunner<T> where T:BaseTestt,ITestLoggerr,new()
    {
        public void Run()
        {
            T test = new T();
            test.SetUp();
            test.Log("Test Started");
            test.Execute();
            //Console.WriteLine("Executing Test");
            test.Log("Test Completed");

        }
    }
}
