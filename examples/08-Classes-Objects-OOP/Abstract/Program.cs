using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human("John", 24);

            john.Greet();

            Animal dog = new Animal(2, 1f);
            dog.Greet();

            //Creature creature = new Creature();
        }
    }
}
