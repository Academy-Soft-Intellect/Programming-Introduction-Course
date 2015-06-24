using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSymetric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 2, 2, 1 };
            bool isSymetric = true;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isSymetric = false;
                    break;
                }
            }

            Console.WriteLine("The array is symetric: " + isSymetric);
        }
    }
}
