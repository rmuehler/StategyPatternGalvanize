namespace StategyPatternGalvanize
{
    public class Car : IChargeFuel
    {
        private int fuelCost = 5;
        public int chargeFuel(int currentCapacity, int maxCapacity)
        {
            return (maxCapacity - currentCapacity) * fuelCost;
        }
    }
}