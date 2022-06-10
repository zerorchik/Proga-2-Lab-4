namespace proga_2_lab_4.Models
{
    public class Port
    {
        public string Name { get; set; }
        public int Koord { get; set; }

        public Port(string name, int x)
        {
            Name = name;
            Koord = x;
        }

        public override string ToString()
        {
            return Name + "\tX: " + Koord;
        }
    }
}
