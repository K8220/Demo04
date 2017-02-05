using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Person
    {
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return Role + "\n - " + "Name: " + FirstName + " " + LastName + "\n - Profession: " + Profession + "\n - Salary: " + Salary;
        }

    }
}
