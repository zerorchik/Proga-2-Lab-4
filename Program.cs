using proga_2_lab_4.Models;
using System;
using System.Collections.Generic;

// this is test pull request

namespace proga_2_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            List<Ship> ships = new List<Ship>
            {
                { new CaterShip("Аврора")},
                { new TankerShip("Геркулес")},
                { new VantagnuyShip("Україна")}
            };

            List<Port> ports = new List<Port>
            {
                { new Port("Гавайський", 3)},
                { new Port("Аутагавський", 7)},
                { new Port("Токійський", 8)}
            };

            foreach (Ship ship in ships)
                Console.WriteLine(ship);

            foreach (Ship ship in ships)
                Console.WriteLine(ship.GetOilType());

            Console.WriteLine("\nОберіть порт з якого ви відпливаєте (0/1/2): ");
            foreach (Port port in ports)
                Console.WriteLine("   " + port);
            int port1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оберіть порт куди ви направляєтесь (0/1/2): ");
            int port2 = Convert.ToInt32(Console.ReadLine());
            int time = Math.Abs(ports[port1].Koord - ports[port2].Koord);
            Console.WriteLine("\nПодорож складатиме " + time + " годин");
            Console.WriteLine();
            foreach (Ship ship in ships)
                Console.WriteLine(ship.GetOil(time));

            Console.WriteLine("\nДодайте нове судно: ");
            Console.WriteLine("Оберіть тип судна (0/1/2): \n   Катер\n   Вантажне судно\n   Танкер");
            int newType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nУведіть його модель: ");
            string model = Console.ReadLine();
            if (newType == 0) ships.Add(new CaterShip(model));
            else if (newType == 1) ships.Add(new VantagnuyShip(model));
            else ships.Add(new TankerShip(model));
            Console.WriteLine("\nУсі судна в порту:");
            foreach (Ship ship in ships)
                Console.WriteLine(ship);

            Console.WriteLine("\nЗнайдіть судна по типу пального (0/1/2): \n   дизель\n   газ\n   нефтеналивне паливо");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 0) Ship.GetCountOfShipsOnOil("дизель", ships);
            else if (type == 1) Ship.GetCountOfShipsOnOil("газ", ships);
            else Ship.GetCountOfShipsOnOil("нефтеналивне паливо", ships);
        }
    }
}
