using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                String test = "Test";
            }
            //Console.WriteLine(test);

        }
        public static void print(int[] args) {
		
		int d = 12;
		
		foreach(int item in args){
			int p = 5;
			Console.WriteLine(item);
		}
        //Console.WriteLine(p);

        Console.WriteLine(d);
		
	}
    }
}
