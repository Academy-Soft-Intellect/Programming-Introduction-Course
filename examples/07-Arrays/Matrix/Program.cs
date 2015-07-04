using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {15, 31, 14, 15, 22},
                {55, 11, 52, 44, 23},
                {44, 3, 8, 87, 91 }
            };

            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(matrix[2, 1]);
            //matrix[2, 1] = 12;
            //Console.WriteLine(matrix[2, 1]);


            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
