using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLifecycle
{
    class Program
    {
        static int b = 5;
        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 2;
            Print("hi");


        }

        static void Print(string hi)
        {
            Console.WriteLine(b);
        }
    }
}
