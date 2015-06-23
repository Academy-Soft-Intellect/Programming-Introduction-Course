using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
