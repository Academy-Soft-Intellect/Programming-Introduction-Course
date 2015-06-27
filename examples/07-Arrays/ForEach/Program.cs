using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 8, 3, 8, 5 };

            Console.WriteLine("Using foreach:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
