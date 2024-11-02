using System.Text;

namespace HomeWork_27._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Car car = new Car("Грузовик", 140, 120.0, 81.0, 2);
            Motorcycle motorcycle = new Motorcycle("BMW s1000 rr", 299, 12, 7, true);
            Helicopter helicopter = new Helicopter("Apache", 293, 1150, 700, 2);
            Ship ship = new Ship("Titanic", 41, 4722143, 4500000, 46328);
            Yacht yacht = new Yacht("Beneteau Oceanis 41", 60, 10000, 600, 7);
            Snowmobile snowmobile = new Snowmobile ("Yamaha", 120, 40, 37, false);
            car.StartEngine();
            car.StopEngine();
            motorcycle.Wheelie();
            helicopter.TakeOff();
            ship.UnloadCargo();
            yacht.StopEngine();
            snowmobile.DriveOnSnow();

            IVehicle[] vehicles = new IVehicle[6];
            vehicles[0] = car;
            vehicles[1] = motorcycle;
            vehicles[2] = helicopter;
            vehicles[3] = ship;
            vehicles[4] = snowmobile;
            vehicles[5] = yacht;

            Console.WriteLine("________________________________________");
            Console.WriteLine("Полиморфизм");

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.StartEngine();
            }
            Console.WriteLine("________________________________________");
            Console.WriteLine("Расширение типа List<int>");
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"Список до перемешивания: {string.Join(", ", myList)}");
            Console.WriteLine($"Список после перемешивания: {string.Join(", ", myList.Random())}");

            Console.WriteLine("________________________________________");
            Console.WriteLine("Расширение типа bool");
            bool firstValue = true;
            Console.WriteLine("Исходное значение bool - " + firstValue);
            Console.WriteLine("Обратное значение bool - " + firstValue.Invert());


        }

    }
}

