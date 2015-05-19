using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal rex = new Animal("Rex", 5);
            rex.Bark();

            Animal sharo = new Animal("Sharo", 2);
            sharo.Bark();
        }
    }
}
