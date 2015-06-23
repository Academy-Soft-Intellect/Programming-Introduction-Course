using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ourArr = new int[n];

            for (int i = 0; i < ourArr.Length; i++)
            {
                ourArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("=======================");


            for (int i = 0; i < ourArr.Length; i++)
            {
                Console.WriteLine(ourArr[i]);
            }

            int a = 5; 
            int b = 6;
            int temp;

            temp = a;
            a = b;
            b = temp;

        }
    }
}
