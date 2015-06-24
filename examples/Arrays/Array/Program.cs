using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pencho = new int[]{3, 6, 12, -7, -1};

            Console.WriteLine(pencho[5]);
            for (int i = 0; i < pencho.Length; i++)
            {
                Console.Write("|" + pencho[i] + "| ");
            }
            Console.WriteLine();
            Console.WriteLine(pencho.Length);

        }
    }
}
