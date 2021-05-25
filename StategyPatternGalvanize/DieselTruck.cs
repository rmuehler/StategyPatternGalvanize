namespace StategyPatternGalvanize
{
    public class DieselTruck : IChargeFuel
    {
        private int fuelCost = 8;
        public int chargeFuel(int currentCapacity, int maxCapacity)
        {
            return (maxCapacity - currentCapacity) * fuelCost;
        }
    }
}