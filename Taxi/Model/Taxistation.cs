using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class TaxiStation
    {
        public static List<Car> FindBySpeed(List<Car> taxis, int _minSpeed, int _maxSpeed)
        {
            List<Car> carRange = new List<Car>();
            foreach (Car taxi in taxis)
            {
                if (taxi.Speed >= _minSpeed && taxi.Speed <= _maxSpeed)
                {
                    carRange.Add(taxi);
                }
            }
            return carRange;
        }


        public static double CalculateCostTaxistation(List<Car> taxis)
        {
            double amount = 0;
            foreach (Car taxi in taxis)
            {
                amount = amount + taxi.Cost;
            }
            return amount;
        }

        public static List<Car> SortByFuelConsumption(List<Car> taxis)
        {
            List<PassengerTaxi> passengerTaxi = new List<PassengerTaxi>();
            List<FreightTaxi> freightTaxi = new List<FreightTaxi>();

            foreach (Car taxi in taxis)
            {
                if (taxi is PassengerTaxi)
                {
                    passengerTaxi.Add(taxi as PassengerTaxi);
                }
                else if (taxi is FreightTaxi)
                {
                    freightTaxi.Add(taxi as FreightTaxi);
                }
            }
            freightTaxi.Sort((taxi1, taxi2) => taxi1.FuelConsumption.CompareTo(taxi2.FuelConsumption));
            passengerTaxi.Sort((taxi1, taxi2) => taxi1.FuelConsumption.CompareTo(taxi2.FuelConsumption));

            List<Car> _result = new List<Car>();
            _result.AddRange(passengerTaxi);
            _result.AddRange(freightTaxi);
            return _result;
        }
    }
}

   

