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
            Console.WriteLine("Print with 3 params");
            Print(3, "a", "b", "c");

            Console.WriteLine("Print with 4 params");
            Print(4, "a", "b", "c", "d");

            Console.WriteLine("Print with 5 params");
            Print(5, "a", "b", "c", "d", "e");

        }


        public static void Print(int counter, params string[] items)
        {
            Console.WriteLine(counter);
            foreach (var item in items)
            {
                Console.Write(item +"\t");
            }
            Console.WriteLine();
        }
    }
}
