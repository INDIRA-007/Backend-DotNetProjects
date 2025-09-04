using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_program
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //}


        //method to check if a string is anagram or not

        public static bool areAnagram(string f_string, string s_string)
        {

            //check if both string length matches are not
            if (f_string.Length != s_string.Length)
            {
                return false;
            }

            //convert string into character array
            char[] f_char = f_string.ToLower().ToCharArray();
            char[] s_char = s_string.ToLower().ToCharArray();

            //sort array
            Array.Sort(f_char);
            Array.Sort(s_char);

            //check if character matches or not

            for (int i = 0; i < f_char.Length; i++)
            {
                if (f_char[i] != s_char[i])
                {
                    return false;
                }
            }
            return true;

        }


        static void Main(string[] args)
        {

            string f_string = "listen";
            string s_string = "silent";
            if(areAnagram(f_string, s_string))
            {
                Console.WriteLine("Both string are anagram string");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string");
            }

        }
    }
}
