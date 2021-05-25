using System;

namespace StategyPatternGalvanize
{
    class Program
    {
        static void Main(string[] args)
        {
            var dieselStrategy = new DieselTruck();
            var electricStrategy = new ElectricCar();
            var jetStrategy = new Jet();
            var carStrategy = new Car();

            var fuelStation = new FuelStation();

            Console.Out.WriteLine("Pumping gas for a car, Cost: ${0}",
                fuelStation.pumpFuel(5, 70, carStrategy));
            
            Console.Out.WriteLine("Pumping jet fuel for a jet, Cost: ${0}",
                fuelStation.pumpFuel(200, 1000, jetStrategy));
            
            Console.Out.WriteLine("Pumping electricity for a electric car, Cost: ${0}",
                fuelStation.pumpFuel(0, 40, electricStrategy));
            
            Console.Out.WriteLine("Pumping gas for a diesel truck, Cost: ${0}",
                fuelStation.pumpFuel(22, 100, dieselStrategy));
            
        }
    }
}