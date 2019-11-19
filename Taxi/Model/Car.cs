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

            if (2000 < year || year > 2019)
            {
                throw new ArgumentException("The year is out of range.");
            }
            this._year = year;

            if (fuel < 0)
            {
                throw new ArgumentOutOfRangeException("Fuel consumption cannot be negative.");
            }
            this._fuel = fuel;

            if (cost < 0)
            {
                throw new ArgumentOutOfRangeException("Cost cannot be negative.");
            }
            Cost = cost;

            if (speed <= 0)
            {
                throw new ArgumentOutOfRangeException("Speed cannot be so small and negative");
            }
            Speed = speed;

            Id = Guid.NewGuid();
        }

        public virtual string Print()
        {
            String taxiInfo = $"FactoryManufacturer: {FactoryManufacturer}, Id : {Id}, Model : {Model}, Year : {Year},  Fuel : {FuelConsumption},  Cost : {Cost},  Speed : {Speed}";
            return taxiInfo;
        }
    }
}
