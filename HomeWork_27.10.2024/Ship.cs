using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_27._10._2024
{
    internal class Ship : IVehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }
        public int CargoCapacity { get; set; }
        public Ship(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int cargoCapacity) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            CargoCapacity = cargoCapacity;
        }

        public void StartEngine()
        {
            Console.WriteLine("Мотор корабля работает");
        }

        public void StopEngine()
        {
            Console.WriteLine("Мотор корабля заглушен");
        }

        internal void LoadCargo()
        {
            Console.WriteLine("Загрузка судна");
        }
        internal void UnloadCargo()
        {
            Console.WriteLine("Разгрузка судна");
        }
    }
}
