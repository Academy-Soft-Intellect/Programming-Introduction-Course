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
            string[] array = new string[]{"abra", "kadabra vbcvbc bhfghf", 
                                        "simsala", "bim", 
                                        "sezam", "otvori", "se"};

            Console.WriteLine(array[1]);

            Console.WriteLine(array.Length);
        }
    }
}
