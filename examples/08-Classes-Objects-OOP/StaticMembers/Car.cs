using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    public class Car
    {

        public static int carsCount = 0;

        private string brand;
        private string model;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car()
        {
            this.brand = "";
            this.model = "";

            carsCount++;
        }

        public Car(string brand, string model) : base()
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
