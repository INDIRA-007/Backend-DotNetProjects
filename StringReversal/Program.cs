using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the input from user
            Console.Write("Enter the string to be reversed: ");
            string input = Console.ReadLine();
            //call the function to be excuted- function declaration
            Console.WriteLine(Reversal(input));

        }

        //function definition

        static string Reversal(string input)
        {
            string reversedString = string.Empty;

            char[] ch = input.ToCharArray();
            for(int chlen = ch.Length-1; chlen >=0; chlen--)
            {
                reversedString = reversedString + ch[chlen];
            }

            return reversedString;
        }

    }
}
