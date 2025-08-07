using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{
    class Student
    {
        //property
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //methods
        public void ShowDetails()
        {
            Console.WriteLine("Student Information: ");
            Console.WriteLine("StudentId: {0}, Name: {1}, Address: {2}", StudentID, Name, Address);
        
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.StudentID = 1;
            stud.Name = "Raj";
            stud.Address = "Lucknow";

            stud.ShowDetails();
            Console.ReadKey();
        }
    }
}
