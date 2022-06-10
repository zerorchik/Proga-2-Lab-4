using System;
using System.Collections.Generic;

namespace proga_2_lab_4.Models
{
    public abstract class Ship 
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int BaggagePower { get; set; }
        public string OilType { get; set; }
        public int OilUsage { get; set; }

        public string GetOilType()
        {
            return Name + " використовує - " + OilType;
        }

        public string GetOil(double num)
        {
            return Name + " дозаправлено!\n   + " + OilUsage * num + " л " + OilType;
        }

        public static void GetCountOfShipsOnOil(string i, List<Ship> ships)
        {
            int count = 0;
            foreach (Ship ship in ships)
                if (ship.OilType == i) count++;
            Console.WriteLine("Кількість суден з типом палива \"" + i + "\" = " + count);
        }

        public override string ToString()
        {
            return Name + "\n   Модель = " + Model + "\n   Швидкість = " + Speed + " км\\год\n   Грузопідйом = " + BaggagePower
                + " кг\n   Тип палива = " + OilType + "\n   Розхід = " + OilUsage + " л\\год\n";
        }
    }
}
