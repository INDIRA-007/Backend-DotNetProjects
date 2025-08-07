using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ExceptionHand
{


    class userDefinedException: Exception
    {

        public userDefinedException(String msg) : base(msg)
        {

        }
        public userDefinedException(string msg, Exception innerEx) : base(msg, innerEx)
        {

        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient Client = null;
            try
            {
                Client = new HttpClient();
                var result = Client.GetAsync("https://www.google.com").Result;
                Console.WriteLine(result.ToString());
            }
            catch(NullReferenceException ex)
            {
                //TO DO: NullReferenceException : specific
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                //TO DO: Exception : general
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Client?.Dispose();

            }


            //custom exception
            try
            {
                //TO DO:
                int x = 2, y = -1, result;
                if( y <= 0)
                {
                    throw new userDefinedException("Y should be greater than 0");
                }
                else
                {
                    result = x / y;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
