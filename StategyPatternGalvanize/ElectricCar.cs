namespace StategyPatternGalvanize
{
    public class ElectricCar : IChargeFuel
    {
        private int fuelCost = 1;
        public int chargeFuel(int currentCapacity, int maxCapacity)
        {
            return (maxCapacity - currentCapacity) * fuelCost;
        }
    }
}