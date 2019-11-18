using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class PassengerTaxi : Car
    {
        private int Passengers;
        private bool BabyCarSeat;
        private bool AirConditioning;

        public PassengerTaxi(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed, int passengers, bool babyCarSeat, bool airConditioning) : base(factoryManufacturer, model, year, fuel, cost, speed)
        {
            Passengers = passengers;
            BabyCarSeat = babyCarSeat;
            AirConditioning = airConditioning;
        }
        public override string ToString()
        {
            return "Passenger Taxi: " + base.ToString() + $", Passengers : {Passengers}, Baby Car Seat : {BabyCarSeat}, Air Conditioning : {AirConditioning}";
        }
    }
}
