using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Car
    {
        private Model _model;
        private int _year;
        private double _fuel;

        public FactoryManufacturer FactoryManufacturer { get; private set; }
        public Guid Id { get; private set; }
        public Model Model { get; private set; }
        public int Year { get; private set; }
        public double FuelConsumption { get; set; }
        public int Cost { get; set; }
        public int Speed { get; set; }


        public Car(FactoryManufacturer factoryManufacturer, Model model, int year, double fuel, int cost, int speed)
        {
            FactoryManufacturer = factoryManufacturer;
            this._model = model;
            this._year = year;
            this._fuel = fuel;
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
