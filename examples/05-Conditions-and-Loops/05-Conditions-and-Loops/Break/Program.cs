using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        private static void Main(string[] args)
        {
            int number = 3;
            int divider = 5;
            int curent_number = 1;

            do
            {
                int result = number * curent_number;
                curent_number++;

                if (result % divider == 0)
                {
                    Console.Write("Least common multiple (LCM): {0} and {1} is {2}", number, divider, result);
                    Console.WriteLine();
                    break;
                }

            } while (true);
        }
    }
}
