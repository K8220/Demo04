using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {
        private bool power = false;
        private readonly int volumeMin = 0;
        private readonly int volumeMax = 9;

        private double frequencyMin = 2000.0;
        private double frequencyMax = 26000.0;

        private int volume = 0;
        private double frequency = 2000.0;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (power == false) { Console.WriteLine("The radio is not on...\n"); }
                else if (value >= volumeMin && value <= volumeMax) {volume = value; Console.WriteLine("Volume set to " + volume + "\n"); }
                else if (value < volumeMin) { Console.WriteLine("Given value too low, set to min instead.\n"); volume = volumeMin; }
                else if (value > volumeMax) { Console.WriteLine("Given value too high, set to max instead.\n"); volume = volumeMax; }
            }
        }
        public double Frequency
        {
            get
            {
               return frequency;
            }
            set
            {   if (power == false) { Console.WriteLine("The radio is not on...\n"); }
                else if (value >= frequencyMin && value <= frequencyMax) { frequency = value; Console.WriteLine("Frequency set to " + frequency + "\n"); }
                else if (value < frequencyMin) { Console.WriteLine("Given value too low, set to min instead.\n"); frequency = frequencyMin; }
                else if (value > frequencyMax) { Console.WriteLine("Given value too high, set to max instead.\n"); frequency = frequencyMax; }
                if (frequency == 2800) { Console.WriteLine("Kuuntelet nyt: Yle X"); }
                if (frequency == 10100) { Console.WriteLine("Kuuntelet nyt: Radio Aalto"); }
            }
        }

        public void PowerSwitch()
        {
            Console.WriteLine("\nYou flipped the power switch.");
            
            if (power == true) { power = false; Console.WriteLine("The radio is now powered off!\n"); }
            else if (power == false) { power = true; Console.WriteLine("The radio is now powered on!\n"); }
        }
        public string Info()
        {

            return ("The radio is powered on: " + power + ", volume is set to: " + volume + " and the frequency is at: " + frequency);
            
        }
    }
}
