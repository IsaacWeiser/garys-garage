using System;
namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Turn(string direction)
        {
            Console.WriteLine(direction);
        }
        public virtual void Stop()
        {
            Console.WriteLine("STOP!");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}