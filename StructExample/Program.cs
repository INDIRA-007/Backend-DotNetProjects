using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct Points
    {
        public int x, y;
        public Points(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Points p1 = new Points(4, 6);// intantization is not mandatory for struct 
            //but mandatory for class
            //Console.WriteLine("x: {0}, y: {1}", p1.x, p1.y);
            Points p2;
            p2.x = 9;
            p2.y = 10;
            Console.WriteLine("x: {0}, y: {1}", p2.x, p2.y);
        }
    }
}
