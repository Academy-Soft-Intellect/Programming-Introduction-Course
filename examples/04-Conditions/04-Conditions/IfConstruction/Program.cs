using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());
            if (numInt == 100)
            {
                Console.WriteLine("The number is 100");
            }

            Console.WriteLine("Prodyljavame napred");
        }
    }
}
