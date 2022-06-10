namespace proga_2_lab_4.Models
{
    public class VantagnuyShip : Ship
    {
        public VantagnuyShip(string model)
        {
            Name = "Вантажне судно";
            Model = model;
            Speed = 59;
            BaggagePower = 65000;
            OilType = "газ";
            OilUsage = 197000;
        }
    }
}
