using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which will be the length of an array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine();

            
            array[0] = 0; 
            array[1] = 1;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);

            for (int i = 2; i < n; i++) 
            {
                array[i] = array[i - 1] + array[i - 2];        

                Console.WriteLine(array[i]);
            }
        }
    }
}

