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
            Print();
            PrintName();
            Print();
            PrintName();
            Print();
            PrintName();
        }

        public static void Print()
        {
            Console.WriteLine("Hello");
            PrintName();
        }

        public static void PrintName()
        {
            Console.WriteLine("Name");
        }
    }
}
