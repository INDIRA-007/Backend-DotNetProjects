using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void ShowStock(string stockName)
        {
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine($"{stockName}: {rnd.Next(100, 200)}");
                Thread.Sleep(500); // Simulate update every half second
            }
        }

        static void Main()
        {
            Thread stock1 = new Thread(() => ShowStock("APPLE"));
            Thread stock2 = new Thread(() => ShowStock("GOOGLE"));
            stock1.Start();
            stock2.Start();
            Console.ReadLine(); // Let user stop manually
        }
    }
}
