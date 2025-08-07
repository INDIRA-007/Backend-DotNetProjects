using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desctructor_1
{
    class Example
    {
        public Example()
        {
            Console.WriteLine("constructor called");
        }
        //destructor
        ~Example()
        {
            //TO DO: Clean up unmanaged objects
            Console.WriteLine("Destructor called to clean up unmanaged objects");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
        }
    }
}
