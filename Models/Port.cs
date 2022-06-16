using System;
using System.Collections.Generic;
using System.Linq;

namespace proga_2_lab_4.Models
{
    public class Port : Base<Port>
    {
        public string Name { get; set; }
        public int Koord { get; set; }

        // Список суден у порту
        public List<Ship> PortShips
        {
            get { return Ship.Items.Values.Where(ship => ship.StartPort == this).ToList(); }
        }

        public Port(string name, int x)
        {
            Name = name;
            Koord = x;
        }

        // Метод підрахунку кількості суден по типу їх палива в конкретному порту
        public void GetCountOfShipsOnOil(string i, Dictionary<Guid, Ship> ships)
        {
            int count = 0;
            foreach (Ship ship in ships.Values)
                if (ship.OilType == i) count++;
            Console.WriteLine("У порту " + this.Name + ", кількість суден з типом палива \"" + i + "\" = " + count);
        }

        public override string ToString()
        {
            return Name + "\tX: " + Koord;
        }
    }
}
