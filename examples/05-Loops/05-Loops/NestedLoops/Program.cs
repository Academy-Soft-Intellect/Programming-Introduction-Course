using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 9;
		    int cols = 6;

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= cols; j++)
                {
                    Console.Write("{0} X {1}", i, j);
                    if (j != cols)
                    {
                        Console.Write(" | ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
