    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = 5;
            float height = 4;

            string area = CalculateRectangleArea(width, height);

            Console.WriteLine("Width " + width + "  Height " + height + " = Area " + area);
            Console.WriteLine();

        }

        public static string CalculateRectangleArea(float width, float height)
        {
            return " Lazar";
            //float area = width * height;
            //return area;
        }
    }
}
