using System;
namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Ram goes RRrrrrrummbbble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The ram has its wheel turn HARD {direction} as the driver spits their dip out of the window");

        }

        public override void Stop()
        {
            Console.WriteLine("The ram slams on the breaks for no rational reason, the light had only just turned yellow... he could have made the light");
        }
        public void RefuelTank()
        {
            FuelCapacity = 100.0;
        }

        public double CurrentTankPercentage()
        {
            return FuelCapacity;
        }
    }
}