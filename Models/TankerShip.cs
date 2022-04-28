namespace proga_2_lab_4.Models
{
    public class TankerShip : Ship
    {
        public TankerShip()
        {
            Name = "Танкер";
            Speed = 26;
            BaggagePower = 120000;
            OilType = "нефтеналивне паливо";
            OilUsage = 330000;
        }
    }
}
