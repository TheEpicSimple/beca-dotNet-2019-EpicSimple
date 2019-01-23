namespace BussinessCoreDLL
{
    public class Carriage
    {
        public string model;
        public uint hexcolor;
        public byte doorNumber;
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
}
