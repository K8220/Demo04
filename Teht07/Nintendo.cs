using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Nintendo:Consoles
    {
        public string Special { get; set; }

        public override string ToString()
        {
            Creator = "Nintendo";
            return base.ToString() + "\nFeatures: " + Special ;
        }
    }
}
