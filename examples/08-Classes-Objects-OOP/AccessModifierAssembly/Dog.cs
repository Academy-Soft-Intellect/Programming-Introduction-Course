using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace Test.TEst
{
    public class Dog : Animal
    {

        public void Print()
        {
            Console.WriteLine(testPublic);
            //Console.WriteLine(testInternal);
            Console.WriteLine(testProtected);
            //Console.WriteLine(testPrivate);
        }
    }
}
