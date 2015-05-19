using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Animal : Creature
    {

        private float height;

        public float Height
        {
            get
            {
                return height;
                ;
            }
            set { height = value; }
        }

        public Animal()
        {
            Age = 0;
            Height = 0f;
        }

        public Animal(int age, float height)
        {
            Age = age;
            Height = height;
        }

        public override void Greet()
        {
            Console.WriteLine("I am na animal and I am " + base.age + " years old.");
            Console.WriteLine("My Height is " + this.height);
        }
    }
}
