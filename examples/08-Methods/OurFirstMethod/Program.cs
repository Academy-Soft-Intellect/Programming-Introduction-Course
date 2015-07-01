using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "My name";

            //PrintMyName(a);

            //Console.WriteLine("..........");
            //Console.WriteLine("Waiting");
            //Console.WriteLine("..........");


            //string b = "Your name";
            //PrintMyName(b);

            int a = 5;
            int b = 6;
            CalculateSum(a, b);
            Console.WriteLine("....................");
            Console.WriteLine(a);

            int x = 8;
            int y = 12;
            CalculateSum(a, b, x, y);
        }

        private static void CalculateSum(int firstNumber, int secondNumber)
        {
            firstNumber++;
            Console.WriteLine(firstNumber);
        }

        private static void CalculateSum(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            Console.WriteLine("The sum is:" + (firstNumber + secondNumber + thirdNumber + fourthNumber));
        }

        static void PrintMyName(string name)
        {
            Console.WriteLine(name);
        }
        private static void CalculateDifference(int firstNumber, int secondNumber)
        {
            Console.WriteLine("The difference is:" + (firstNumber - secondNumber));
        }


    }
}
