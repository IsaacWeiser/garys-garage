using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Pink",
                MaximumOccupancy = 2,
                BatteryKWh = 16.4

            };
            Tesla modelS = new Tesla()
            {
                MainColor = "White",
                MaximumOccupancy = 5,
                BatteryKWh = 8.3
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Purple",
                MaximumOccupancy = 4,
                FuelCapacity = 1.2
            };
            Ram bigBoi = new Ram()
            {
                MainColor = "Blue",
                MaximumOccupancy = 5,
                FuelCapacity = 5.9

            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            bigBoi.Drive();
            bigBoi.Turn("left");
            bigBoi.Stop();
        }
    }
}
