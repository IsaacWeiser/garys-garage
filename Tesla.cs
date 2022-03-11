using System;
namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Tesla goes BBBBBrrrrRRRRR");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The tesla Ai turns its self to the {direction} because of tech stuff");

        }

        public override void Stop()
        {
            Console.WriteLine("this car can also brake itself because 'future'");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}