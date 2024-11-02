using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Snowmobile : IVehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }
        public bool HasHeatedSeats { get; set; }
        public Snowmobile(string name, int maxSpeed, double fuelCapacity, double intoGasTank, bool hasHeatedSeats) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            HasHeatedSeats = hasHeatedSeats;
        }

        public void StartEngine()
        {
            Console.WriteLine("Мотор снегохода работает");
        }

        public  void StopEngine()
        {
            Console.WriteLine("Мотор снегохода заглушен");
        }

        internal void DriveOnSnow()
        {
            Console.WriteLine("Снегоход едет по снегу");
        }
    }
}
