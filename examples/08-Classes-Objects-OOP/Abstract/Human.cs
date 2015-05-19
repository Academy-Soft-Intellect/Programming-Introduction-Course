using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
   public class Human : Creature {

	private string name;

       public string Name
       {
           get { return name; }
           set { name = value; }
       }

       public Human()
       {
           Name = string.Empty;
           Age = 0;
       }
	
	public Human(string name, int age){
        Name = name;
        Age = age;
	}
		

	public override void Greet() {
		Console.WriteLine("Hello I am " + this.name);
		Console.WriteLine("I am " + base.age + " years old");
	}
}
}
