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

            List<Port> ports = new List<Port>
            {
                { new Port("Гавайський", 3)},
                { new Port("Аутагавський", 7)},
                { new Port("Токійський", 8)}
            };

            List<Ship> ships = new List<Ship>
            {
                { new CaterShip("Аврора", ports[0])},
                { new TankerShip("Геркулес", ports[1])},
                { new VantagnuyShip("Україна", ports[2])}
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

            // Додавання нового судна до списку суден вказаного порта (реалізація списку суден в класі Port)
            Console.WriteLine("\nДОДАЙТЕ НОВЕ СУДНО: ");
            Console.WriteLine("Оберіть тип судна (0/1/2): \n   Катер\n   Вантажне судно\n   Танкер");
            int newType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nУведіть його модель: ");
            string model = Console.ReadLine();
            Console.WriteLine("\nВиберіть порт нового судна (0/1/2): ");
            int port0 = Convert.ToInt32(Console.ReadLine());

            if (newType == 0) new CaterShip(model, ports[port0]);
            else if (newType == 1) new VantagnuyShip(model, ports[port0]);
            else new TankerShip(model, ports[port0]);

            Console.WriteLine("\nСУДНА У ВСІХ ПОРТАХ:");
            foreach (Ship ship in Ship.Items.Values)
                Console.WriteLine(ship);

            // Виклик методу підрахунку кількості суден за типом пального (реалізація в класі Port)
            Console.WriteLine("\nЗНАЙДІТЬ СУДНО ПО ТИПУ ПАЛЬНОГО (0/1/2): \n   дизель\n   газ\n   нефтеналивне паливо");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВиберіть порт, у якому хочете порахувати кількість суден за вказним типом палива (0/1/2): ");
            int port3 = Convert.ToInt32(Console.ReadLine());

            if (type == 0) ports[port3].GetCountOfShipsOnOil("дизель", Ship.Items);
            else if (type == 1) ports[port3].GetCountOfShipsOnOil("газ", Ship.Items);
            else ports[port3].GetCountOfShipsOnOil("нефтеналивне паливо", Ship.Items);
        }
    }
}
