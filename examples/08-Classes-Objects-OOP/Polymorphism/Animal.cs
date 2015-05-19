using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
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
    }
}
