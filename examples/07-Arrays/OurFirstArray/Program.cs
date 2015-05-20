using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input k = ");
            int k = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = n; i > n - k; i--)
            {
                result *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                result *= i;
            }

            Console.WriteLine("N!*K!/(N-K)! = " + result);

        }
    }
}
