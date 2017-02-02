using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 1;
            while (elevator.Floor != 10)
            {
                elevator.Callout();
                string line = Console.ReadLine();
                elevator.Floor = int.Parse(line);

            }
            Console.ReadLine();
        }
    }
}
