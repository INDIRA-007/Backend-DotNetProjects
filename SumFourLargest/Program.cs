using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFourLargest
{
    internal class Program
    {
        int SumFourLargest(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            return nums.OrderByDescending(n => n).Take(4).Sum();
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Program pro = new Program();
            Console.WriteLine(pro.SumFourLargest(nums));
        }
    }
}
