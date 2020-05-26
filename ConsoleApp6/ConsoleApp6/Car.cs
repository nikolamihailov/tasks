using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
   public class Car
    {
        public double HorsePowers { get; set; }
        public string Manufacture { get; set; }
        public int CarWeight { get; set; }
        public string Boost { get; set; }
        private double zeroToHundred;
        public double ZeroToHundred
        {
            get
            {
                if (Boost == "do-100")
                {
                    zeroToHundred = (1 / HorsePowers * 500) * 0.7;
                }
                else
                {
                    zeroToHundred = (1 / HorsePowers * 500);
                }
                return zeroToHundred;
            }
        }
        private double hundredToTwoHundred;
        public double HundredToTwoHundred
        {
            get
            {
                if (Boost == "do-200")
                {
                    hundredToTwoHundred = (1 / HorsePowers * 500) * 0.8;
                }
                else
                {
                    hundredToTwoHundred = (1 / HorsePowers) * 500;
                }

                return hundredToTwoHundred;
            }
        }
        public Car(double horsePowers, string boost)
        {
            this.HorsePowers = horsePowers;
            this.Boost = boost;
        }
    }
}
