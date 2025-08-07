using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class User
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //TO DO: throw exception or anything else
                    throw new ArgumentNullException("argument value can't be null or empty");
                }
                firstName = value;
                fullName = firstName + " " + lastName;
            }
        }
        private string  lastName;

        public string  LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                fullName = firstName + " " + lastName;
            }
        }

        private string  fullName;

        public string FullName
        {
            get { return fullName; }
            //set { fullName = value; }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User usr = new User();
                //usr.FirstName = "";
                usr.FirstName = "Raja";
                //Console.WriteLine(usr.FirstName);
                usr.LastName = "Amir";
                Console.WriteLine("full name: {0}" + usr.FullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
