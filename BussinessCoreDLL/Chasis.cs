namespace BussinessCoreDLL
{
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
}
