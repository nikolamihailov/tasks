using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Racer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }
        public Car Car { get; set; }

        public Racer(string firstName, double horsePowers, string boost)
        {
            this.FirstName = firstName;
            this.Car = new Car(horsePowers, boost);

        }
        public override string ToString()
        {
            return FirstName + " " + Points;
        }
    }
}
