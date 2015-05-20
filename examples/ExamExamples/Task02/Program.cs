using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arrays size:");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Console.WriteLine("Filling first array...");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Please enter array1[{0}]", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Filling second array...");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Please enter array2[{0}]", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The common elements are:");

            for (int i = 0; i < array1.Length; i++)
            {
                //if (array2.Contains(array1[i]))
                //{
                //    Console.WriteLine(array1[i]);
                //}
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i]==array2[j])
                    {
                        Console.WriteLine(array2[j]);
                    }
                }
            }

        }
    }
}
