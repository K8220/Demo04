using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Consoles consoles = new Consoles();
            Nintendo nintendo = new Nintendo();
            New3DS new3ds = new New3DS();
            N64 n64 = new N64();

            new3ds.Price = 299.99;
            new3ds.Year = 2015;
            Console.WriteLine(new3ds.ToString());
            Console.WriteLine();

            nintendo.Name = "Switch";
            nintendo.Price = 399.99;
            nintendo.Year = 2017;
            nintendo.Special = "Docking system allowing for handheld gaming.";
            Console.WriteLine(nintendo.ToString());
            Console.WriteLine();
            
            new3ds.Name = "NEW LUL";
            Console.WriteLine(new3ds.ToString());
            Console.WriteLine();

            Console.WriteLine(n64.ToString());



        }
    }
}
