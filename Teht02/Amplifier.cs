using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Amplifier
    {
        private readonly int minVolume = 1;
        private readonly int maxVolume = 100;
        private int volume { get; set; }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 100 && value >= 1)
                {
                    volume = value;
                }
                
                else if (value <= minVolume)
                {
                    Console.WriteLine("Can't set volume lower than 1. Set to lowest.");
                    volume = minVolume;
                }
                else if (value >= maxVolume)
                {
                    Console.WriteLine("Can't set volume higher than 100. Set to maximum.");
                    volume = maxVolume;
                }
            }
        }
    }
}
