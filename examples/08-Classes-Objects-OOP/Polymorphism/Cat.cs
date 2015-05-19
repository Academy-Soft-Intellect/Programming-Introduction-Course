using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat : Animal, IMoveable, ISleepable
    {
	
	public void WakeUp() {
		Console.WriteLine("Cat is awake");
	}

	public void Sleep() {
        Console.WriteLine("Cat is sleeping");
	}

	public void Walk() {
        Console.WriteLine("Cat is walking");
	}

	public void Run() {
        Console.WriteLine("Cat is running");
	}

}
}
