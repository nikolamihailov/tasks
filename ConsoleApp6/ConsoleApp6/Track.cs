using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Track
    {
        public Racer Racer { get; set; }
        public Racer Racer2 { get; set; }

        public Track(Racer racer, Racer racer2)
        {
            Racer = racer;
            Racer2 = racer2;
        }
        public void TrackA()
        {
            if (Racer.Car.ZeroToHundred < Racer2.Car.ZeroToHundred)
                Racer.Points += 3;
        }

        public void TrackB()
        {
            if (Racer.Car.ZeroToHundred + Racer.Car.HundredToTwoHundred < Racer2.Car.ZeroToHundred + Racer2.Car.HundredToTwoHundred)
                Racer.Points += 3;
        }
    }
}
