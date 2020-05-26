using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Racer> racers = new List<Racer>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input.ToLower() == "end")
                {
                    break;
                }
                string[] data = input.Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                Racer r = new Racer(data[0], double.Parse(data[4]), data[5]);
                racers.Add(r);
            }
            foreach (var racer in racers)
            {
                foreach (var racer1 in racers.Where(x => x != racer))
                {
                    Track trackA = new Track(racer, racer1);
                    trackA.TrackA();
                    Track trackB = new Track(racer, racer1);
                    trackB.TrackB();
                }
            }
            foreach (var racer in racers.OrderByDescending(x => x.Points))
            {
                Console.WriteLine(racer);
            }
            
        }
    }
}
