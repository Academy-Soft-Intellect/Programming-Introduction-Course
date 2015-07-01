using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int result = Sum(a, b);

            Console.WriteLine(result);
        }

        private static int Sum(int a, int b)
        {
            int c = a + b;

            return c;
        }
        
    }
}
