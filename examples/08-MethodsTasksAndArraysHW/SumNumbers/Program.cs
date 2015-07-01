using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            Sum(a, b);
        }

        private static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(a+b);
        }
    }
}
