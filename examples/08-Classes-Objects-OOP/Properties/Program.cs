using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cat josefine = new Cat("Josefine", "Persian", 2);
            josefine.SayMiau(true);
            josefine.SayMiau(false);


            Cat harriet = new Cat("Harriet", "Siamese", 5);
            harriet.SayMiau(true);
            harriet.Age = -2;
            harriet.SayMiau(true);
        }
    }
}
