using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParameterizedConstructor
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string College { get; set; }

        //default constructor
        public Student()
        {
            College = "JPR College";
        }

        //parameter constructor
        public Student(int StudentId, string name, string college)
        {
            this.StudentId = StudentId;
            this.Name = name;
            this.College = college;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Console.WriteLine("Student Name: {0}, College: {1}, Student Id: {2}", objStudent.Name, objStudent.College, objStudent.StudentId);


            Student st = new Student(123, "Raj", "IIT");
            Console.WriteLine("Student Name: {0}, College: {1}, Student Id: {2}", st.Name, st.College, st.StudentId);

        }
    }
}
