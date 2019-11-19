using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> taxistation = new List<Car>()
            {
                new PassengerTaxi (FactoryManufacturer.Skoda, Model.Rapid, 2019, 8, 23000, 170, 4, true, true),
                new PassengerTaxi (FactoryManufacturer.Volkswagen, Model.Polo, 2018, 7.3, 21500, 180, 4, false, false),
                new FreightTaxi (FactoryManufacturer.Gas, Model.Volga3102, 2016, 12, 27800, 150, 2000),
                new FreightTaxi (FactoryManufacturer.Ford, Model.Transit, 2013, 11.6, 27100, 150, 3000),
                new FreightTaxi (FactoryManufacturer.Iveco, Model.Dialy, 2017, 17, 40300, 190, 5000)
            };

            Console.WriteLine("Calculating tati station cost ");
            double totalCost = TaxiStation.CalculateCostTaxistation(taxistation);
            Console.WriteLine($"Taxi station total cost is ${totalCost}");
            Console.WriteLine();

            Console.WriteLine("Sarting taxi by fuel consumption ");
            List<Car> sortedTaxiByFuelConsumption = TaxiStation.SortByFuelConsumption(taxistation);
            foreach (var taxi in sortedTaxiByFuelConsumption)
            {
                Console.WriteLine(taxi);
            }
            Console.WriteLine();

            Console.WriteLine("Find taxi by speed");
            List<Car> findTaxiBySpeed = TaxiStation.FindBySpeed(taxistation, 180, 190);
            if (findTaxiBySpeed.Count == 0)
            {
                Console.WriteLine("No cars found in this speed range");
            }
            else
            {
                foreach (Car taxi in findTaxiBySpeed)
                {
                    Console.WriteLine(taxi);
                }
                Console.ReadKey();
            }
        }
    }
}

        
    

