namespace Garage
{
    public interface IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery();

        public double CurrentChargePercentage();
    }

    public interface IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank();
        public double CurrentTankPercentage();
    }
}