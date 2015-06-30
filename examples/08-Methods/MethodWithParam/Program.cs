using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 10;

            int c = Sum(a, b, 5);

            Console.WriteLine(c);
        }

        private static int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = firstNumber + secondNumber + thirdNumber;
            return result;

        }
    }
}
