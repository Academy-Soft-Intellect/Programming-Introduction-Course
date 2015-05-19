using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TimeSpan week = new TimeSpan(7);
            Console.WriteLine("One week has " + week.CalculateHours() + " hours");
            Console.WriteLine("One week has " + week.CalculateMinutes() + " minutes");

            TimeSpan month = new TimeSpan(30);
            Console.WriteLine("One month has " + month.CalculateHours() + " hours");
            Console.WriteLine("One month has " + month.CalculateMinutes() + " minutes");
        }
    }
}
