using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinGapTimeInterval
{
    internal class Program
    {
        static TimeSpan GetMinGap(string[] intervals)
        {
            var times = new List<(TimeSpan start, TimeSpan end)>();
            foreach (var interval in intervals)
            {
                var parts = interval.Split('-');
                var start = DateTime.Parse(parts[0]).TimeOfDay;
                var end = DateTime.Parse(parts[1]).TimeOfDay;
                times.Add((start, end));
            }
            times = times.OrderBy(t => t.start).ToList();
            TimeSpan minGap = TimeSpan.MaxValue;

            for (int i = 1; i < times.Count; i++)
            {
                var gap = times[i].start - times[i - 1].end;
                if (gap > TimeSpan.Zero && gap < minGap)
                {
                    minGap = gap;
                }
            }
            return minGap;

        }

        static void Main(string[] args)
        {
            string[] intervals =
            {
                "9:00 AM-10:30 AM", "11:00 AM-12:00 PM"
            };

            TimeSpan minGap = GetMinGap(intervals);
            Console.WriteLine($"Minimum gap between intervals:{minGap}");
        }
    }
}
