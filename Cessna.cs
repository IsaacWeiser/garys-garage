using System;
namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 100.0;
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The plane swivels its tiny front wheel to the {direction} and then requires a 40 point turn to turn 90 degrees");

        }

        public override void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Plane goes Zooooooooom!");
        }

        public double CurrentTankPercentage()
        {
            return FuelCapacity;
        }
    }
}