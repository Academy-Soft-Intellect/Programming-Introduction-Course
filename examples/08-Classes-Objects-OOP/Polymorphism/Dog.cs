using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : Animal, IMoveable
    {

        protected string breed;

        public Dog(string breed)
        {

        }

        public void Walk()
        {
            Console.WriteLine("Dog is walking");
        }

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }

    }
}
