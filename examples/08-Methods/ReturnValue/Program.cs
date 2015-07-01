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
            //float width = 5;
            //float height = 4;

            //double area = CalculateRectangleArea(width, height);

            //Console.WriteLine("Width " + width + "  Height " + height + " = Area " + area);
            //Console.WriteLine();

            string myStr = "Helloss";
            bool isStringHello = CheckString(myStr);
            Console.WriteLine(isStringHello);
        }

        private static bool CheckString(string myStr)
        {
            if (myStr=="Hello")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalculateRectangleArea(float width, float height)
        {
            float calculatedArea = width * height;
            return calculatedArea;
        }
    }
}
