using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    abstract class Car
    {
        public FactoryManufacturer FactoryManufacturer { get; }
        public Guid Id { get; set; }
        public Model Model { get; }
        public int Year { get; }
        public double FuelConsumption { get; set; }
        public int Cost { get; set; }
        public int Speed { get; set; }

        public Car(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed)
        {
            Model = model;
            Year = year;
            FuelConsumption = fuel;
            Cost = cost;
            Speed = speed;
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            String taxiInfo = $"FactoryManufacturer: {FactoryManufacturer}, Id : {Id}, Model : {Model}, Year : {Year},  Fuel : {FuelConsumption},  Cost : {Cost},  Speed : {Speed}";
            return taxiInfo;
        }
    }
}
