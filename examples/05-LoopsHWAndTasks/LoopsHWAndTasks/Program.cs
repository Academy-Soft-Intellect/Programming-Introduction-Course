using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHWAndTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //int currentNumber = 0;

            //do
            //{
            //    Console.WriteLine("Enter a number:");
            //    currentNumber = int.Parse(Console.ReadLine());
            //    sum = sum + currentNumber;

            //} while (currentNumber != 0);

            //Console.WriteLine(sum);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }

            //int sum = 0;
            //int currentNumber = 0;

            //do
            //{
            //    Console.WriteLine("Enter a number:");
            //    currentNumber = int.Parse(Console.ReadLine());
            //    sum = sum + currentNumber;

            //} while (currentNumber != 0);

            //Console.WriteLine(sum);

            //int n = int.Parse(Console.ReadLine());
            //int max = int.MinValue;
            //int min = int.MaxValue;


            //for (int i = 1; i <= n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number>max)
            //    {
            //        max = number;
            //    }
            //    if (number<min)
            //    {
            //        min = number;
            //    }
            //}

            //Console.WriteLine("Max is:" + max);
            //Console.WriteLine("Min is:" + min);

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int factorialL = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }

            for (int i = 1; i <= n - k; i++)
            {
                factorialL *= i;
            }
            Console.WriteLine(factorialN * factorialK / factorialL);
        }
    }
}
