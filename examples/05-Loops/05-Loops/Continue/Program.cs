using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }

                Console.Write("Odd digit: {0}", i);
                Console.WriteLine();
            }
        }
    }
}
