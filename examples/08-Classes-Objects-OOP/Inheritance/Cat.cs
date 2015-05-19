using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Pet
    {
        private string breed;

        public Cat() : base()
        {
            this.breed = "";
        }

        public Cat(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }
        public void SayBreed()
        {
            Console.WriteLine("My breed is: " + this.breed);
        }
    }
}
