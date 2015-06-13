using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a new number:");

            float x = float.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine();
            Console.Write("Целочислено деление на 3:    ");
            float y = x / 3;
            Console.WriteLine(y);

            Console.Write("Деление по модул на 3:    ");
            float z = x % 3;
            Console.WriteLine(z);


            int income = 10;
            Console.WriteLine(income + "asdasdas");

        }
    }
}
