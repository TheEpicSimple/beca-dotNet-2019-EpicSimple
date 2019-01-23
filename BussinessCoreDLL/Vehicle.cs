using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessCoreDLL
{
    public class Vehicle
    {
        public VehicleType vehicleType;
        public string model;

        public string engine;
        public string[] tires;
        public Chasis chasis;
        public Carriage carriage;

        public ulong priceEuroCents;

        public Vehicle()
        {
            this.vehicleType = VehicleType.tourism;
            this.model = "standart";
            this.engine = "standart";
            this.chasis = new Chasis();
            this.carriage = new Carriage();
            this.priceEuroCents = 200000;
        }

        public Vehicle(VehicleType vehicleType, string model, string engine, string[] tires,
            Chasis chasis, Carriage carriage, ulong priceEuroCents)
        {
            this.vehicleType = vehicleType;
            this.model = model;
            this.engine = engine;
            this.tires = tires;
            this.chasis = chasis;
            this.carriage = carriage;
            this.priceEuroCents = priceEuroCents;
        }
    }
}
