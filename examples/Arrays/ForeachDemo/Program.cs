using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int[] ourArr = new int[] {1,7,3,4,5};

            //for (int i = 0; i < ourArr.Length; i++)
            //{
            //    ourArr[i] = int.Parse(Console.ReadLine());
            //}

            Console.WriteLine("======================");

            foreach (int myElement in ourArr)
            {
                Console.WriteLine(myElement);
            }

        }
    }
}
