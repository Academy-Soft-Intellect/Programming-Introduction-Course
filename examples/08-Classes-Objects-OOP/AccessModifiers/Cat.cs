using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Cat : Animal
    {
        public void Print()
        {
            Console.WriteLine(testPublic);
            Console.WriteLine(testInternal);
            Console.WriteLine(testProtected);
            //Console.WriteLine(testPrivate);
        }
    }
}