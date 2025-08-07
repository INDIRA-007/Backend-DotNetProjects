using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExample
{
    class user
    {
        [Obsolete("ShowDetails method is obselete, use DisplayDetails")]
        public void ShowDetails()
        {
            //TO DO:
            Console.WriteLine("old method");
        }
        public void DisplayDetails()
        {
            //TO DO:
            Console.Write("new method");
        }
    }
    [AttributeUsage(AttributeTargets.Class)]
    class TypeInfoAttribute : Attribute
    {
        private string name;
        public string Description;
        public TypeInfoAttribute(string name)
        {
            this.name = name;
        }
    }

    [TypeInfo("user", Description = "Student Class")]
    class Student
    {
       // [TypeInfo("user")]
        public int UserId { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            user usr = new user();
            usr.ShowDetails();

            Student stu = new Student();
            object[] attr = stu.GetType().GetCustomAttributes(typeof(Student), true);

            foreach (var at in attr)
            {
                Console.WriteLine(at);
            }
        }
    }
    
}
