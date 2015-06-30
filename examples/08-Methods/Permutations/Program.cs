using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static readonly int n = int.Parse(Console.ReadLine());


        static int[] a = new int[50];
        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + 1 + " ");

            }
            Console.WriteLine();
        }
        static void permute(int k)
        {
            int i, swap;
            if (k == 0)
            {
                Print();
            }
            else
            {

                for (i = 0; i < k; i++)
                {
                    swap = a[i];
                    a[i] = a[k - 1];
                    a[k - 1] = swap;
                    permute(k - 1);

                    swap = a[i];
                    a[i] = a[k - 1];
                    a[k - 1] = swap;

                }
            }
        }
        static void Main()
        {
            for (int i = 1; i < n; i++)
            {

                a[i] = i;

            }
            Console.WriteLine();
            permute(n);
        }
    }
}
