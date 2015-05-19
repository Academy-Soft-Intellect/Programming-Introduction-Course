using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Animal
    {

        protected string name;
        public int age;

        public Animal()
        {

        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

    }
}
