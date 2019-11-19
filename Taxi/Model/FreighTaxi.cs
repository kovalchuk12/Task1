using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class FreightTaxi : Car
    {
        private int _carryingCapacity;

        public FreightTaxi(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed, int carryingCapasity) : base(factoryManufacturer, model, year, fuel, cost, speed)
        {
            if (carryingCapasity < 0)
            {
                throw new ArgumentOutOfRangeException("Carrying capacity cannot be negative.");
            }
            _carryingCapacity = carryingCapasity;
        }
        public override string Print()
        {
            return "Fraight Taxi: " + base.ToString() + $", Carrying Capasity : {_carryingCapacity}";
        }
    }
}
