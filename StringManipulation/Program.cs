using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Dot Net Tricks Skills Challend";

            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}",arr[i]);
            }

            string str1 = String.Concat(str, ", You should try");
            Console.WriteLine(str1);

            int index = str.IndexOf("Skills");
            Console.WriteLine(index);

            string newStr = str.Replace("Challend", "Challenges");
            Console.WriteLine(newStr);

            string lower = str.ToLower();
            Console.WriteLine(lower);

            string upper = str.ToUpper();
            Console.WriteLine(upper);

            string substring = str.Substring(0,25);
            Console.WriteLine(substring);

            //Console.ReadKey();

            //immutable - System.String
            //mutable - System.Text.StringBuilder

            string newString = "Hellow World";
            newString.Replace("World", "Dot Net developer");  //immutable string
            Console.WriteLine(newString);

            StringBuilder newStringBuilder = new StringBuilder("Hello World!");
            newStringBuilder.Replace("World", ".Net developers");
            Console.WriteLine(newStringBuilder);

            //verbatim string
            //preceded by @ character
            //a verbatim does not have escapre character
            //useful to spefify File path, SQL stirng, XML


            //non-verbatim string having escape sequence
            string str2 = "C:\\Program Files\\Microsoft.Net";

            //verbatim string, no need of escapre sequence character
            string strverbatim = @"c:\Program Files\Microsoft.NET";

        }
    }
}
