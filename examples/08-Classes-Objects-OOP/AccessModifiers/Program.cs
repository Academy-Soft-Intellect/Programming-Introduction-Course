using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        private static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.testPublic);
            Console.WriteLine(a.testInternal);
        }
    }
}
