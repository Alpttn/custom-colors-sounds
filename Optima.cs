using System;

namespace Custom_Colors_sounds {
public class Optima : Vehicle {  // car

public Optima(string color, double battery, int maxOcc  ) : base(color, maxOcc) 
        {
            BatteryKWh = battery; 
        }
    public double BatteryKWh { get; set; }
    // public void ChargeBattery () { ... }
     public override void Drive () {
        Console.WriteLine($"The {this.MainColor} Optima zips by you!");
    }
}
}