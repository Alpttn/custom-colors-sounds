using System;

namespace Custom_Colors_sounds {
public class Cessna : Vehicle {  // Propellor light aircraft

public Cessna(string color, double fuel, int maxOcc) : base(color, maxOcc) 
        {
            FuelCapacity = fuel; 
        }
    public double FuelCapacity { get; set; }
    // public void RefuelTank () { ... }
    public override void Drive() {
        Console.WriteLine($"The {this.MainColor} Cessna flashes by you!");
    }
   
    public override void Stop() {
        Console.WriteLine($"The {this.MainColor} Cessna is stopped by chuck norris!");
    }
}
}