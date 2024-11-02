using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Helicopter : IVehicle
    {

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }
        public int RotorBlades { get; set; }
        public Helicopter(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int rotorBlades) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            RotorBlades = rotorBlades;
        }

        public  void StartEngine()
        {
            Console.WriteLine("Мотор вертолета работает");
        }

        public  void StopEngine()
        {
            Console.WriteLine("Мотор вертолета заглушен");
        }

        internal void TakeOff()
        {
            Console.WriteLine("Вертолет взлетел");
        }
        internal void Land()
        {
            Console.WriteLine("Вертолет приземлился");
        }

    }
}
