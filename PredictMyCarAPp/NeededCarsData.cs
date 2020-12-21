namespace PredictMyCarAPp
{
    public class NeededCarsData
    {
        public int Hour { get; set; }
        //public bool NeedsCar { get; set; }

        public decimal Value { get; set; }

        public NeededCarsData(int hour,  decimal value)
        {
            Hour = hour;
            //NeedsCar = needsCar;
            Value = value;
        }

        public NeededCarsData(NeededCarsData neededCarsData)
        {
            this.Hour = neededCarsData.Hour;
            this.Value = neededCarsData.Value;
        }

    }
}