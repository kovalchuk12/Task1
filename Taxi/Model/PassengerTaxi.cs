using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class PassengerTaxi : Car
    {
        private int _passengers;
        private bool _babyCarSeat;
        private bool _airConditioning;

        public PassengerTaxi(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed, int passengers, bool babyCarSeat, bool airConditioning) : base(factoryManufacturer, model, year, fuel, cost, speed)
        {
            if (passengers <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cost));
            }
            _passengers = passengers;
 
            _babyCarSeat = babyCarSeat;
            _airConditioning = airConditioning;
        }
        public override string ToString()
        {
            return "Passenger Taxi: " + base.ToString() + $", Passengers : {_passengers}, Baby Car Seat : {_babyCarSeat}, Air Conditioning : {_airConditioning}";
        }
    }
}
