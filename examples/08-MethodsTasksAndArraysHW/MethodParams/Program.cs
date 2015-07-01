using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello Bulgaria";
            string goodBye = "Bye";
            int chislo = 3;

            Print(hello, chislo);

            Print(goodBye, chislo);

        }

        public static void Print(string ourString, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(ourString);
            }
            number++;
        }
    }
}
