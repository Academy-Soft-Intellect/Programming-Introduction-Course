using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Cat
    {
        private string name;
        private string breed;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat()
        {
            this.name = "";
            this.breed = "";
            this.age = 0;
        }

        public Cat(string name, string breed, int age) : this()
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public void SayMiau(bool identify)
        {
            Console.WriteLine("Miauuuuuu Myrrrrr!");

            if (identify)
            {
                SayName();
                SayBread();
                SayAge();
            }
        }

        private void SayName()
        {
            Console.WriteLine("My pretty name is " + this.Name);

        }

        private void SayBread()
        {
            Console.WriteLine("The best breed in the world is mine : " + this.Breed);
        }

        private void SayAge()
        {
            Console.WriteLine("I am young lady at " + this.Age);
        }
    }
}
