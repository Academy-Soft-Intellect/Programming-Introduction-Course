using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MethodsTasksAndArraysHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input matrix size n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];
            int row = 0;
            int col = -1;
            int num = 1;
            int step = n;
            string direction = "Right";

            while (num <= n*n)
            {
                if (direction == "Right")
                {
                    for (int k = 0; k < step; k++)
                    {
                        col++;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Down";
                    step--;
                }

                if (direction == "Down")
                {
                    for (int k = 0; k < step; k++)
                    {
                        row++;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Left";
                }

                if (direction == "Left")
                {
                    for (int k = 0; k < step; k++)
                    {
                        col--;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Up";
                    step--;
                }

                if (direction == "Up")
                {
                    for (int k = 0; k < step; k++)
                    {
                        row--;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Right";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format(array[i, j] + " \t"));
                }
                Console.WriteLine();
            }
        }
    }
}
