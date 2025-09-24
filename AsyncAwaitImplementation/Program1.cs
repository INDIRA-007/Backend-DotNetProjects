using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitImplementation
{
    internal class Program1
    {

        #region Main

        private static void Main(string[] args)
        {
            Console.WriteLine($"Main Start - Thread {Environment.CurrentManagedThreadId}");
            CallSync();
            var channelName = GetChannelName();
            LikeShare(channelName);
            Console.WriteLine($"Main End - Thread {Environment.CurrentManagedThreadId}");
        }

        #endregion

        #region Sync Call
        private static void CallSync()
        {
            Console.WriteLine($"Sync - Before API call - Thread {Environment.CurrentManagedThreadId}");
            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.google.com")
            };
            HttpClient client = new HttpClient();
            client.Send(request);
            Console.WriteLine($"Sync - After API call - Thread {Environment.CurrentManagedThreadId}");
            Task.Delay(1000).GetAwaiter().GetResult();
            Console.WriteLine($"Call Sync completed - Thread {Environment.CurrentManagedThreadId}");
        }

        #endregion
        
    }
