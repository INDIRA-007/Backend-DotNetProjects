using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllnumbtvalues
{
    internal class Program
    {
        static List<int> GenerateRandomNumbers(int A, int B)
        {
            var num = Enumerable.Range(A, B).ToList();
            var random = new Random();
            return num.OrderBy(x => random.Next()).ToList();
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 20;
            List<int> rand = GenerateRandomNumbers(a, b);
            Console.WriteLine(string.Join(", ",rand));
        }
    }
}
