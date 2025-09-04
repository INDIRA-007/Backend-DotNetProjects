using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambdaexp
{
    class program
    {
        delegate int delegate1(int i);
        static void Main(string[] args)
        {
            delegate1 d1 = a => a * a;
            int x = d1(7);
            Console.WriteLine(x);
            Console.ReadLine();
            
        }
    }
}