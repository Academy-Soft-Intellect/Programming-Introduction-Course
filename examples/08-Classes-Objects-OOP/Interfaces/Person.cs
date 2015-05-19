using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Person : Walkable
    {

        protected string firstName;
        protected string lastName;

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Walk()
        {
            Console.WriteLine("Walking...");

        }

        public void Walk(int distrance)
        {
            Console.WriteLine("Walking " + distrance + " kilometers...");

        }


    }
}
