using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Animal
    {

        public string testPublic;

        internal string testInternal;

        protected string testProtected;

        private string testPrivate;

        public Animal()
        {
            testPublic = "public";
            testInternal = "no modifier";
            testProtected = "protected";
            testPrivate = "private";
        }

        public void Print()
        {
            Console.WriteLine(testPublic);
            Console.WriteLine(testInternal);
            Console.WriteLine(testProtected);
            Console.WriteLine(testPrivate);
        }


    }
}
