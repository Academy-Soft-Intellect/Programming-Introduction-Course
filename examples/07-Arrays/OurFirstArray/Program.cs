using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Max elementh is: " + array.Max());
            Console.WriteLine("Min elementh is: " + array.Min());

        }
    }
}
