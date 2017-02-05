using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Boss boss = new Boss();
            Employee employee = new Employee();

            // Employee
            employee.FirstName = "Saara";
            employee.LastName = "Laine";
            employee.Role = "Employee";
            employee.Profession = "Teacher";
            employee.Salary = 1200;
            System.Diagnostics.Debug.WriteLine(employee.ToString());
            Console.WriteLine(employee.ToString());

            // Boss
            boss.FirstName = "Mika";
            boss.LastName = "Saari";
            boss.Role = "Boss";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Bonus = 5000;
            boss.Car = "Volvo";
            System.Diagnostics.Debug.WriteLine(boss.ToString());
            Console.WriteLine(boss.ToString());

            // Employee promotion
            employee.Promotion();
            System.Diagnostics.Debug.WriteLine(employee.ToString());
            Console.WriteLine(employee.ToString());

        }
    }
}
