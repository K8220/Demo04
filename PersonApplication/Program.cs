using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            Teacher teacher = new Teacher();
            teacher.FirstName = "Taneli";
            teacher.LastName = "Sormustin";
            teacher.Room = "D220";
            teacher.Address = "Jyväskylä Piippukatu 2";
            teacher.PhoneNumber = "050-1234567";
            teacher.Age = 20;
            Console.WriteLine(teacher.ToString());
            teacher.TeacherMethod();
            Console.WriteLine();

            Student student = new Student("Late","Gee","K1337");
            student.PhoneNumber = "010-22233344";
            student.Age = 12;
            student.Address = "Roskis";
            Console.WriteLine(student.ToString());
            student.StudentMethod();
            Console.WriteLine();
        }
    }
}
