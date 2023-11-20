using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Naz
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int i = 0; // i is a variable of type int

                // Student s1; // s1 is a variable of type Student
                // s1 is a reference variable

                Student s1 = new Student(); // object or instance of Student class
                s1.RollNumber = 1;
                s1.Name = "Ajay";
                s1.City = "Pune";
                // s1.CourseName = "Dot Net";
                s1.Print();

                Student s2 = new Student();
                s2.Create(2, "Chetan", "Mumbai");
                // s2.CourseName = "Dot Net";
                s2.Print();

                Student.CourseName = "C#"; // we can change value of static field

                Student s3 = new Student();
                s3.Create(3, "Farin", "Pune");
                s3.Print();

                //World w1 = new World(); // error creating object of static class

                //World w2 = new World(); // error creating object of static class

                Console.WriteLine($"{World.NumberOfCountries}");

                Console.ReadLine();
            }
        }


    }
}
