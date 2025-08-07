using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPrivateConstructor
{
    public class Example
    {
        private static int Counter;

        //private constructor - static members can be called using class name
        private Example()
        {
            Counter = 10;
        }

        //static constructor
        static Example()
        {
            Counter = 20;
        }

        //public constructor
        public Example(int count)
        {
            Counter = Counter + count;
        }

        public static int GetCounter()
        {
            return ++Counter;
        }

        //nested class
        public class NestedExample
        {
            public void test()
            {
                //internal instance
                Example example = new Example();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //external instance can not be created as below
            //Example ex = new Example();

            //Console.WriteLine("Counter: {0}", Example.GetCounter());

            Example ex = new Example(10);
            Console.WriteLine("Counter: {0}", Example.GetCounter());



            //call static constructor before creating object

            Example ex1 = new Example(10);
            Console.WriteLine("Counter: {0}", Example.GetCounter());
        }
    }
}
