using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array Rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array Columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Please enter array[{0},{1}]", i,j);
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }

            int min = int.MaxValue;
            int rowMax = 0;
            int colMax = 0;
            int rowMin = 0;
            int colMin = 0;
            int max = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i,j]>max)
                    {
                        max = array[i, j];
                        rowMax = i;
                        colMax = j;
                    }

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        rowMin = i;
                        colMin = j;
                    }
                }
            }

            Console.WriteLine("The max number is: {0}, located on [{1},{2}]", max, rowMax, colMax);
            Console.WriteLine("The min number is: {0}, located on [{1},{2}]", min, rowMin, colMin);


        }
    }
}
