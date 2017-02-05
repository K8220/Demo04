using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class N64 : Nintendo
    {
        public override string ToString()
        {
            Name = "N64";
            Price = 300;
            Year = 1994;
            Special = "Classic";
            return base.ToString();
        }
    }
}
