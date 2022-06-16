namespace proga_2_lab_4.Models
{
    public class VantagnuyShip : Ship
    {
        public VantagnuyShip(string model, Port port)
        {
            Name = "Вантажне судно";
            Model = model;
            StartPort = port;
            Speed = 59;
            BaggagePower = 65000;
            OilType = "газ";
            OilUsage = 197000;
        }
    }
}
