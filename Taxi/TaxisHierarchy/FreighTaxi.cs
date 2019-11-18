using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class FreightTaxi : Car
    {
        private int CarryingCapacity;

        public FreightTaxi(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed, int carryingCapasity) : base(factoryManufacturer, model, year, fuel, cost, speed)
        {
            CarryingCapacity = carryingCapasity;
        }
        public override string ToString()
        {
            return "Fraight Taxi: " + base.ToString() + $", Carrying Capasity : {CarryingCapacity}";
        }
    }
}
