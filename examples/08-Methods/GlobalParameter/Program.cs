using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalParameter
{
    class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            IncrementCounter();
            IncrementCounter();
            IncrementCounter();
            IncrementCounter();


            Console.WriteLine(counter);


        }

        private static void IncrementCounter()
        {
            counter++;
        }
    }
}
