using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 4, 11, 68, 232, 5, 16, 15, 11, 55, 300 };

            Console.WriteLine("Enter a numbers  and you will see its first index:");
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == n)
            //    {
            //        Console.WriteLine("The index is on position: {0}", i);
            //        isFound = true;
            //        break;
            //    }
            //}


            int index = Array.IndexOf(array, n);
            Console.WriteLine("The index is on position: {0}", index);
        }
    }
}
