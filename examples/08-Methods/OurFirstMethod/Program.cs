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
            string a = "My name";


            int b = 5;
            Program.PrintMyName(new int[5], out b);



            //Console.WriteLine();
            //Console.WriteLine("Waiting....");
            //Console.WriteLine();

            //string secondName = "Your name";
            //PrintMyName(secondName);
        }

        static void PrintMyName(int[] ar, out int b)
        {
            ar[2] = 5;
            b = 10;
        }



    }
}
