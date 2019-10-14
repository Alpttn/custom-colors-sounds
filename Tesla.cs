using System;

namespace Custom_Colors_sounds {
public class Tesla : Vehicle {  // Electric car
public Tesla(string color, double battery, int maxOcc) : base(color, maxOcc) 
        {
            BatteryKWh = battery; //using this proptery from the base class. overwrites the 10000
        }
    public double BatteryKWh { get; set; }
    // public void ChargeBattery () { ... }
    public override void Drive () {
        Console.WriteLine($"The {this.MainColor} Tesla blazes by you!");
    }
    public override void Turn() {
        Console.WriteLine($"The {this.MainColor} Tesla squeals around a right turn");
    }
    public override void Stop() {
        Console.WriteLine($"The {this.MainColor} Tesla's auto pilot crashes!");
    }
}
}