using System;

namespace Custom_Colors_sounds
{

    public class Vehicle
    {
        public Vehicle(string color, int speed)
        {
            MainColor = color;
            MaximumOccupancy = speed;
        }
        public Vehicle() //ask
        {

        }

        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("The vehicle carefully turns right");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop");
        }
    }
}