using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
     interface IVehicle     {

            public string Name { get; set; }
            public int MaxSpeed { get; set; }
            public double FuelCapacity { get; set; }
            public double IntoGasTank { get; set; }


            public void StartEngine();


            public void StopEngine();
        }
}
