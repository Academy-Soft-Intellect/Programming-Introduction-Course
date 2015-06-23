using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchConstruction
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Enter day of the week: ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day!");
            //        break;
            //}

            Console.WriteLine("Enter a letter or string: ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "a":
                case "b":
                case "c":
                    Console.WriteLine("A,B,C");
                    break;

                case "x":
                case "y":
                case "z":
                    Console.WriteLine("X,Y,Z");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
