// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int SumFourLargest(int[] nums)
{
    if (nums == null || nums.Length == 0)
        return 0;
    return nums.OrderByDescending(n => n).Take(4).Sum();
}
