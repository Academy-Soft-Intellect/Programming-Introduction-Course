using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[]{"a", "AA", 
                                        "aaa", "AAAA", 
                                        "aaaaa", };

            Console.WriteLine(array[2]);

            Console.WriteLine(array.Length);
        }
    }
}
