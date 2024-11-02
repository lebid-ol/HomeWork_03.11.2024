using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Car : IVehicle
    {
        public int NumberOfDoors { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }

        public Car(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int numberOfDoors) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            NumberOfDoors = numberOfDoors;
        }

        public  void StartEngine()
        {
            Console.WriteLine("Мотор автомобиля работает");
        }

        public   void StopEngine()
        {
            Console.WriteLine("Мотор автомобиля заглушен");
        }

        internal void Honk ()
        {
            Console.WriteLine("Автомобиль издает звук");
        }

    }
}
