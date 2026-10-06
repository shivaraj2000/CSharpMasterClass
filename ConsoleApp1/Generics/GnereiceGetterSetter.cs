using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Generics
{
    internal class GnereiceGetterSetter<T>
    {
        public string TrxID { get; set; }
        public T Data { get; set; }
    }
}
