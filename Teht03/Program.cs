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
            
            Console.WriteLine(boss.ToString());
            Console.WriteLine();
            Console.WriteLine(employee.ToString());
        }
    }
}
