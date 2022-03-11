using System;
namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} motorcycle goes aschhhhhheeeeeeewwww2w");

        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"the motorcycle screeches to a {direction} turn");

        }

        public override void Stop()
        {
            Console.WriteLine("The motorcyclist decides to do a wheelie in order to stop");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}