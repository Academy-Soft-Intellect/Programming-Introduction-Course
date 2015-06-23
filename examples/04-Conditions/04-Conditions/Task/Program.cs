using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 5)
            {
                if (numInt % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else if (numInt >= 6 && numInt <= 15)
            {
                if (numInt % 3 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                if (numInt == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if (numInt > 0)
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }
        }
    }
}
