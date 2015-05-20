using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please enter array[{0}]",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    if (array[i]>max)
                    {
                        max = array[i];
                    }
                }
                else
                {
                    if (array[i]<min)
                    {
                        min = array[i];
                    }
                }
            }
            Console.WriteLine("The max even index number is: {0}", max);
            Console.WriteLine("The min odd index number is: {0}", min);
        }
    }
}
