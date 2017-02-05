using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Bike bike = new Bike();
            Boat boat = new Boat();

            vehicle.Variation = "Car";
            vehicle.Name = "Subaru";
            vehicle.Model = "Legacy";
            vehicle.Year = 1994;
            vehicle.Color = "White";
            System.Diagnostics.Debug.WriteLine(vehicle.ToString());
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine();

            bike.Variation = "Bike";
            bike.Name = "Nopsa";
            bike.Model = "Master";
            bike.Color = "Black";
            bike.Year = 2015;
            bike.Gear = true;
            bike.GearModel = "Something";
            System.Diagnostics.Debug.WriteLine(bike.ToString());
            Console.WriteLine(bike.ToString());
            Console.WriteLine();

            bike.Variation = "Bike2";
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Color = "Red";
            bike.Year = 2006;
            bike.Gear = false;
            bike.GearModel = "None";
            System.Diagnostics.Debug.WriteLine(bike.ToString());
            Console.WriteLine(bike.ToString());
            Console.WriteLine();

            boat.Variation = "Boat";
            boat.Name = "Yamaha";
            boat.Model = "S900";
            boat.Year = 1990;
            boat.Color = "White";
            boat.Type = "Speed";
            boat.Seat = 2;
            System.Diagnostics.Debug.WriteLine(boat.ToString());
            Console.WriteLine(boat.ToString());
            Console.WriteLine();


        }
    }
}
