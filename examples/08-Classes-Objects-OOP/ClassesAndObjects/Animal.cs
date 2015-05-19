using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Animal
    {

        private string name;
        private int age;

        public Animal()
        {
            this.name = "";
            this.age = 0;
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Bark()
        {
            Console.WriteLine("Bowwow, I am " + this.name + "!");
            Console.WriteLine("Bowwow, I am " + this.age + " years old dog!");
        }

    }
}
