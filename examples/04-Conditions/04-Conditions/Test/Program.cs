using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            bool isTrue = myString == "Hello";

            Console.WriteLine(myString=="Hello");
        }
    }
}
