using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 2, 1 };

            int[] array2 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            foreach (int item in array2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
