using System;

namespace Custom_Colors_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
        // Move all common properties in your vehicles to a new Vehicle class.
        // Create an instance of each vehicle.
        // Define a different value for each vehicle's properties.
        // Create a Drive() method in the Vehicle class.
        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e.   "The blue Ram drives past. RRrrrrrummbbble!").

        Optima kia = new Optima("black", 100.02, 4);
        Cessna cessna = new Cessna("white", 300.01, 2);
        Tesla tesla = new Tesla("burgundy", 200.01, 4);
        Ram ram = new Ram("silver", 101.99, 3);

        kia.Drive();
        kia.Turn();
        kia.Stop();
        Console.WriteLine();
        cessna.Drive();
        cessna.Turn();
        cessna.Stop();
        Console.WriteLine();
        tesla.Drive();
        tesla.Turn();
        tesla.Stop();
        Console.WriteLine();
        ram.Drive();
        ram.Turn();
        ram.Stop();


            
        }
    }
}
