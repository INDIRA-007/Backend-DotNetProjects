using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int n = 4;
            //int result=0;
            //int col = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    result = 1;
            //    for (int j = 1; j <= col; j++)
            //    {
            //        if (j == n)
            //        {
            //            Console.Write(result);
            //        }
            //        else
            //        {
            //            Console.Write(result + " ");
            //            result++;
            //        }
            //    }
            //    col++;
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int n = 5;
            //int r = n;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write("_");
            //    }
            //    for (int j = 1; j <= r; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    r--;
            //    Console.WriteLine();
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    if (i == 1 || i == n || j == 1 || j == n-i)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write("_");
                }
                Console.WriteLine();
            }


        }
    }
}
