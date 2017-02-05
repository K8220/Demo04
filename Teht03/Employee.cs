using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Employee : Person
    {
        public override string ToString()
        {
            return base.ToString() + "\n";
        }

        public void Promotion()
        {
            Profession = "Principal Teacher";
            Salary = Salary + 1000;
        }
    }

   
}
