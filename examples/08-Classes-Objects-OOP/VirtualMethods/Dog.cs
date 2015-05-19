using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Dog : Animal
    {
        protected string breed;

        public Dog(string breed)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("Goodbye!!!");
        }

        //public override void SayGoodbye()
        //{
        //    Console.WriteLine("Goodbye");
        //}


    }
}
