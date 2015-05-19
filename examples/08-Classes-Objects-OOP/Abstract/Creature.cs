using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Creature
    {
        protected int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public abstract void Greet();
    }
}
