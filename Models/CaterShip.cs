namespace proga_2_lab_4.Models
{
    public class CaterShip : Ship 
    {
        //public CaterShip()
        //{
        //    Name = "Катер";
        //    Speed = 18;
        //    BaggagePower = 1200;
        //    OilType = "дизель";
        //    OilUsage = 43;
        //}
        public CaterShip(string model)
        {
            Name = "Катер";
            Model = model;
            Speed = 18;
            BaggagePower = 1200;
            OilType = "дизель";
            OilUsage = 43;
        }
    }
}
