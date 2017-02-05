using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        public string Variation { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Variation + " Info \n - Name: " + Name + " Model: " + Model + " Year: " +  Year + " Color: " + Color;
        }
    }
}
