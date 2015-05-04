using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt % 2  == 0)
            {
                Console.WriteLine("The number is even!");
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }

            if (numInt > 0 && numInt <= 10)
            {
                Console.WriteLine("The number is in the interval (0;10]");
            }
            else if (numInt > 10 && numInt < 50)
            {
                Console.WriteLine("The number is in the interval (10;50)");
            }
            else if (numInt >= 50 && numInt < 1000)
            {
                Console.WriteLine("The number is in the interval [50;1000)");
            }
            else
            {
                Console.WriteLine("The number is out of the interval");
            }
        }
    }
}
