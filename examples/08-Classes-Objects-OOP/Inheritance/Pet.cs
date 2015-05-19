using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Pet
    {
        protected string name;
        protected int years;

        public Pet()
        {
            this.name = "";
            this.years = 0;
        }

        public Pet(string name, int years):base()
        {
            this.name = name;
            this.years = years;
        }

        public void Greet()
        {
            Console.WriteLine("Hello I am " + this.name);
            Console.WriteLine("I am " + this.years + ". years old");
        }
    }

}
