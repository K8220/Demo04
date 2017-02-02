using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Boss : Person
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        public string Role = "Boss";
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }
    }
}
