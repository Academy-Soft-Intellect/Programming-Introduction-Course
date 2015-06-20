using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a new number: ");
            string str = Console.ReadLine();

            int x = int.Parse(str);

            Console.WriteLine(x);
            Console.WriteLine();
            Console.Write("x / 3 = ");
            int y = x / 3;
            Console.WriteLine(y);

            Console.Write("x % 3 = ");
            int z = x % 3;
            Console.WriteLine(z);

        }
    }
}
