using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Consoles
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Creator + " " + Name + "\n" + Year + "\n" + Price + " Euros ";
        }
    }
}
