using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_27._10._2024
{
    internal class Yacht : IVehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelCapacity { get; set; }
        public double IntoGasTank { get; set; }
        public int NumberOfCabins { get; set; }
        public Yacht(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int numberOfCabins) 
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
            IntoGasTank = intoGasTank;
            NumberOfCabins = numberOfCabins;
        }

        public  void StartEngine()
        {
            Console.WriteLine("Мотор яхты работает");
        }

        public  void StopEngine()
        {
            Console.WriteLine("Мотор яхты заглушен");
        }

        internal void DropAnchor()
        {
            Console.WriteLine("Якорь опущен");
        }
        internal void RaiseAnchor()
        {
            Console.WriteLine("Якорь поднят");
        }
    }
}
