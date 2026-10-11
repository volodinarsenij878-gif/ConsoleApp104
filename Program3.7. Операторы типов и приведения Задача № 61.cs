using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program61
{
    internal class Program
    {
        static void Main()
        {
            object obj = "Hello";
            bool checr = obj is string;
            Console.WriteLine(checr); // True
        }
    }
}

