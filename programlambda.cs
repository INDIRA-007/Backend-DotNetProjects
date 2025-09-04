using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambdaexp
{
    class program
    {
        delegate int delegate1(int i);
        // static void Main(string[] args)
        // {
        //     delegate1 d1 = a => a * a;
        //     int x = d1(7);
        //     Console.WriteLine(x);
        //     Console.ReadLine();
            
        // }


        delegate bool D2();
        delegate bool D3(int i);

        class Test
        {
            D2 del2;
            D3 del3;
            public void testmethod(int input)
            {
                int p=0;
                del2 = () => { p=10; return p>input;};
                del3 = (x) => { return x == p};
                Console.WriteLine("P={0}", p);
                bool boolResult = del2();
                Console.WriteLine("p={0}, b={1}", p, boolResult);

            }
            // static void Main(string[] args)
            // {
            //     Test t = new Test();
            //     t.testmethod(5);
            //     bool res = t.del3(10);
            //     Console.WriteLine(res);

            // }

            static void Main(string[] args)
            {
                int[] src = new[] {4,3,5,6,7,3,21};
                foreach(int j in src.where(x=> {
                    if(x <=3)
                        return true;
                    else if(x>=7)
                        return true;
                    else
                        return false;
                        
                }))
            }
        }
    }
}