using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Boat:Vehicle
    {
        public string Type { get; set; }
        public int Seat { get; set; }

        public override string ToString()
        {
            return base.ToString() +"\n - Boat Type: " + Type + " Seat count:" + Seat;
        }
    }
}
