namespace StategyPatternGalvanize
{
    public class Jet : IChargeFuel
    {
        private int fuelCost = 10;
        public int chargeFuel(int currentCapacity, int maxCapacity)
        {
            return (maxCapacity - currentCapacity) * fuelCost;
        }
    }
}