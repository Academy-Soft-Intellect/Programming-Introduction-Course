using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gosho = new string[] { "We", "Are", "The", "Champions" };

            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 5;
            }

            //Console.WriteLine(gosho[3]);
            //Console.WriteLine(gosho[0]);
            //Console.WriteLine(gosho[1]);
            //Console.WriteLine(gosho[2]);
            //Console.WriteLine(gosho.Length);

            foreach (int tosho in arr)
            {
                Console.WriteLine(tosho + 1);
            }
        }
    }
}
