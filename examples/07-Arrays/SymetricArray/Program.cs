using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymetricArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 3, 2, 1 };
            int[] array = new int[] { 1, 2, 3,3, 2, 1 };
            bool isSymetric = true;

            //for (int i = 0; i < array.Length/2; i++)
            //{
            //    if (array[i] != array[array.Length - i - 1])
            //    {
            //        isSymetric = false;
            //        break;
            //    }
            //}

            int arrLength = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[arrLength - i])
                {
                    isSymetric = false;
                }
            }

            Console.WriteLine(isSymetric);
        }
    }
}
