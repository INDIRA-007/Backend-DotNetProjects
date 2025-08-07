using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be reversed: ");
            string input = Console.ReadLine();
            //Call the function 
            Console.WriteLine(wordReversal(input));
        }
        // split the word from string using buildin functions
        static string wordReversal(string input)
        {
            //split the word from the string using buildin function
            string[] words = input.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            
            return string.Join(" ", words);
        }


    }
}
