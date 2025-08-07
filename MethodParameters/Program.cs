using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameters
{
    class Utility
    {
        public void CallbyValue(int x)
        {
            x = 10; 
        }

        public void CallbyRef(ref int x)
        {
            x = 10;  //optional to set the value
        }

        public void CallbyOut(out int x)
        {
            x = 20;  //mandatory to set the value
        }
        public int CallbyOptional(int x, int y=1)
        {
            return x * y;
        }

        public void CallbyParams(int x, params int[] y)
        {
            foreach(var item in y)
            {
                Console.Write(item + " ");

            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 8;  //mandatory to initizalize the value
            int num3=4; //optial to initizalize the value
            Utility utl = new Utility();
            Console.WriteLine("Value before calling method: {0}", num1);
            utl.CallbyValue(num1);
            Console.WriteLine("\nValue after calling method: {0}", num1);

            Console.WriteLine();

            Console.WriteLine("Value before calling method: {0}", num2);
            utl.CallbyRef(ref num2);
            Console.WriteLine("\nValue after calling method: {0}", num2);

            Console.WriteLine();

            Console.WriteLine("Value before calling method: {0}", num3);
            utl.CallbyOut(out num3);
            Console.WriteLine("\nValue after calling method: {0}", num3);

            Console.WriteLine();
            int result = utl.CallbyOptional(6, 5);
            Console.WriteLine("result: {0}", result);

            Console.WriteLine();
            result = utl.CallbyOptional(6);
            Console.WriteLine("result: {0}", result);

            Console.WriteLine();
            Console.WriteLine("Params: ");
            utl.CallbyParams(4, 5, 9, 6, 58, 2);
            

        }
    }
}
