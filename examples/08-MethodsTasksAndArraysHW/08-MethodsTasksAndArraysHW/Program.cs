using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MethodsTasksAndArraysHW
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
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
            Direction currentDirection = Direction.Right;

            while (step > 0)
            {
                if (currentDirection == Direction.Right)
                {
                    for (int k = 0; k < step; k++)
                    {
                        col++;
                        array[row, col] = num;
                        num++;
                    }
                    currentDirection = Direction.Down;
                    step--;
                }

                if (currentDirection == Direction.Down)
                {
                    for (int k = 0; k < step; k++)
                    {
                        row++;
                        array[row, col] = num;
                        num++;
                    }
                    currentDirection = Direction.Left;
                }

                if (currentDirection == Direction.Left)
                {
                    for (int k = 0; k < step; k++)
                    {
                        col--;
                        array[row, col] = num;
                        num++;
                    }
                    currentDirection = Direction.Up;
                    step--;
                }

                if (currentDirection == Direction.Up)
                {
                    for (int k = 0; k < step; k++)
                    {
                        row--;
                        array[row, col] = num;
                        num++;
                    }
                    currentDirection = Direction.Right;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format(array[i, j] + "  "));
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
