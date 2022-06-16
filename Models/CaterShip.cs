namespace proga_2_lab_4.Models
{
    public class CaterShip : Ship 
    {
        public CaterShip(string model, Port port)
        {
            Name = "Катер";
            Model = model;
            StartPort = port;
            Speed = 18;
            BaggagePower = 1200;
            OilType = "дизель";
            OilUsage = 43;
        }
    }
}
