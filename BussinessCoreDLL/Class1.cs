using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessCoreDLL
{
    public class Class1
    {     
    }

    public enum VehicleType : byte { tourism, truck, van, camper, special };

    public class Chasis
    {
        public string model;
        public byte wheelSockets;

        public float[] dimensions;

        public Chasis()
        {
            model = "standart";
            wheelSockets = 4;

            dimensions = new float[] { 2.0f, 4.5f, 1.6f };
        }

        public Chasis(string model, byte wheelSockets, float[] dimensions)
        {
            this.model = model;
            this.wheelSockets = wheelSockets;
            this.dimensions = dimensions;
        }
    }

    public class Carriage
    {
        public string model;
        public uint hexcolor;
        public byte doorNumber;
        // 0 light F dark
        // int max is 2,147,483,647, uint is 4,294,967,295 = 0xFFFFFFFF

        public float[] dimensions;

        public Carriage()
        {
            model = "standart";
            hexcolor = 0x0;
            doorNumber = 5;

            dimensions = new float[] { 2.0f, 4.5f, 1.6f };
        }

        public Carriage(string model, uint hexcolor, byte doorNumber, float[] dimensions)
        {
            this.model = model;
            this.hexcolor = hexcolor;
            this.doorNumber = doorNumber;
            this.dimensions = dimensions;
        }
    }

    public class Vehicle
    {
        public VehicleType vehicleType;
        public string model;

        public string motor;
        public string[] tires;
        public Chasis chasis;
        public Carriage carriage;

        public ulong price; //price in cents

        public Vehicle()
        {
            vehicleType = VehicleType.tourism;
            model = "standart";
            motor = "standart";
            chasis = new Chasis();
            carriage = new Carriage();

            price = 200000;
        }

        public Vehicle(VehicleType vehicleType, string model, string motor, string[] tires, Chasis chasis, Carriage carriage, ulong price)
        {
            this.vehicleType = vehicleType;
            this.model = model;
            this.motor = motor;
            this.tires = tires;
            this.chasis = chasis;
            this.carriage = carriage;
            this.price = price;
        }
    }
}
