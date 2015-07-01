using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
