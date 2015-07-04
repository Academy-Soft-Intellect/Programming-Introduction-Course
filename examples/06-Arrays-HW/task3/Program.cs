using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Еvery single element is equal to the index multiplied by 10:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;     
                Console.WriteLine(array[i]);
            }
        }
    }
}
