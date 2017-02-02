using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            amplifier.Volume = 1;
            int check = 1;
            while (check != 0)
            {
            Console.Write("Give a volume (0-100) > ");
                string line = Console.ReadLine();
                amplifier.Volume = int.Parse(line);
                check = int.Parse(line);
                Console.WriteLine(" --> Volume set to : " + amplifier.Volume);
                Console.WriteLine();
            }
        }
    }
}
