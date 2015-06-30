using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNumberOfParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Call method with 2 params");
            PrintNames(count, "a", "B");

            Console.WriteLine("Call method with 3 params");
            PrintNames(count, "c", "d", "e");


            Console.WriteLine("Call method with 4 params");
            PrintNames(count, "f", "g", "h", "i");
        }

        private static int PrintNames(int counter, params string[] names)
        {
            Console.WriteLine(counter);
            foreach (string name in names)
            {
                Console.Write(name+"\t");
            }
            Console.WriteLine();
            return 0;
        }
    }
}
