using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt%2 == 0)
            {
                if (numInt > 10)
                {
                    Console.WriteLine("The number is even and larger then 10!");
                }
                else
                {
                    Console.WriteLine("The number is even and smaller then 10!");
                }
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }
        }
    }
}
