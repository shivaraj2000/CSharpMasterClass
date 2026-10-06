using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class TestExecuteor_BaseClass
    {
        public static void ExecuteTest<T>(T test)
            where T:BaseTest_Genrics
        {
            test.SetUp();
        }
    }
}
