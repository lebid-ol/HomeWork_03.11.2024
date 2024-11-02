using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Motorcycle : IVehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }
        public bool HasSider { get; set; }
        public Motorcycle(string name, int maxSpeed, double fuelCapacity, double intoGasTank, bool hasSider) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            HasSider = hasSider;
        }

        public  void StartEngine()
        {
            Console.WriteLine("Мотор мотоцикла работает");
        }

        public void StopEngine()
        {
            Console.WriteLine("Мотор мотоцикла заглушен");
        }

        internal void Wheelie()
        {
            Console.WriteLine("Мотоцикл выполняет трюк вилли");
        }
    }
}
