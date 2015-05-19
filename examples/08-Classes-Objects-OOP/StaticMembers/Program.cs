using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A7");

            Console.Write("Cars count: " + Car.carsCount);
            Console.Write("First car: " + audi.Model + " " + audi.Brand);
            Console.WriteLine();

            Car bmw = new Car("BMW", "X6");

            Console.Write("Cars count: " + Car.carsCount);
            Console.Write("First car: " + bmw.Model + " " + bmw.Brand);
            Console.WriteLine();

            Car vw = new Car("Volkswagen", "touareg");

            Console.Write("Cars count: " + Car.carsCount);
            Console.Write("First car: " + vw.Model + " " + vw.Brand);
            Console.WriteLine();
        }
    }
}
