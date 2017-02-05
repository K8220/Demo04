using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            Console.WriteLine("0. To quit. \n1. For power switch. \n2. For frequency set. \n3. For Volume set. \n4. To display this message again. \n5. Displays the status.");
            Console.WriteLine(radio.Info());
            Console.Write("Make a selection > ");
            string line1 = Console.ReadLine();
            int Pick = int.Parse(line1);

            while (Pick != 0)
            {
                switch (Pick)
                {
                    case 0:
                        break;
                    case 1:
                        radio.PowerSwitch();
                        break;
                    case 2:
                        Console.Write("Give a new frequency (2000.0 - 26000.0) >");
                        string lineFreq = Console.ReadLine();
                        radio.Frequency = double.Parse(lineFreq);
                        break;
                        
                    case 3:
                        Console.Write("Give a new volume (0 - 9) >");
                        string lineVol = Console.ReadLine();
                        radio.Volume = int.Parse(lineVol);
                        break;
                    case 4:
                        Console.WriteLine("0. To quit. \n1. For power switch. \n2. For frequency set. \n3. For Volume set. \n4. To display this message again. \n5. Displays the status.");
                        break;
                    case 5:
                        Console.WriteLine(radio.Info());
                        break;
                }
                
                Console.Write("Make a selection > ");
                line1 = Console.ReadLine();
                Pick = int.Parse(line1);
            }
        }
    }
}
