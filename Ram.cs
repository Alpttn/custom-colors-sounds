using System;

namespace Custom_Colors_sounds {
public class Ram : Vehicle {  // Gas powered truck

public Ram(string color, double fuel, int maxOcc) : base(color, maxOcc) 
        {
            FuelCapacity = fuel; //using this proptery from the base class. 
        }
    public double FuelCapacity { get; set; }
    // public void RefuelTank () { ... }
    public override void Drive () {
        Console.WriteLine($"The {this.MainColor} Ram growls by you!");
    }
}
}