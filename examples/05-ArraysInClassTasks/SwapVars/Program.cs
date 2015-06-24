using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A=" + a);
            Console.WriteLine("B=" + b);
        }
    }
}
