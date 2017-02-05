using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class New3DS:Nintendo
    {
        public bool Handheld { get; set; }

        public override string ToString()
        {
            Name = "NEW 3DS";
            Handheld = true;
            return base.ToString() + "\nHandheld: " + Handheld;
        }
    }
}
