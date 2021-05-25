namespace StategyPatternGalvanize
{
    public class FuelStation
    {
        public int pumpFuel(int currentCapacity, int maxCapacity, IChargeFuel strategy)
        {
            return strategy.chargeFuel(currentCapacity, maxCapacity);
        }
    }
}