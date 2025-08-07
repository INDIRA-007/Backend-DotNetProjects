using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfProperty
{
    class User
    {
        //read-write
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //write-only
        private DateTime dob;
        public DateTime DOB
        {
            set { dob = value; }
        }

        //read-only
        private int age;
        public int Age
        {
            get { return age; }
        }

        //auto-implemented
        public string FullName { get; set; }


    }


    class TempRecord
    {
        //array of temperature value
        private float[] temps = new float[5] { 56.2F, 25.3F, 96.4F, 97.3F, 42.8F };

        public int Length
        {
            get
            {
                return temps.Length;
            }
        }
        //indexer
        public float this[int index]
        {
            get
            {
                if(index < Length)
                {
                    return temps[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("index should be in range 0-4");
                }
            }
            set
            {
                if(index < Length)
                {
                    temps[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("index should be in range 0-4");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TempRecord temp = new TempRecord();
            //set accessor
            temp[0] = 87.65F;
            temp[0] = 69.2F;

            for(int i=0; i < temp.Length; i++)
            {
                Console.WriteLine("Element {0} = {1}",i,temp[i]);
            }
            Console.ReadKey();
        }
    }
}
