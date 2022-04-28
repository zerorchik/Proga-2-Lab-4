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
                { new CaterShip()},
                { new TankerShip()},
                { new VantagnuyShip()}
            };

            foreach (Ship ship in ships)
                Console.WriteLine(ship);

            foreach (Ship ship in ships)
                Console.WriteLine(ship.GetOilType());

            Console.WriteLine("\nОберіть тривалість плавання у годинах: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            foreach (Ship ship in ships)
                Console.WriteLine(ship.GetOil(num));
        }
    }
}
