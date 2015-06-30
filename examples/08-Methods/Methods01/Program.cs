using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            PrintArrayReverse(arr);

            string text = "asdasdasd";
            PrintStringReverse(text);
        }

        private static void PrintStringReverse(string text)
        {
            for (int i = text.Length - 1; i > -1; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }

        private static void PrintArrayReverse(int[] arr)
        {
            for (int i = arr.Length - 1; i > -1; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }


    }
}
