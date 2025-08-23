using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\LENOVO\Documents\DotNetprojects2025";
            List<string> TextLines = new List<string>();
            File.ReadAllLines(FilePath).ToList();

            foreach (string line in TextLines)
            {
                Console.WriteLine(line);
            }

            TextLines.Add("Try to add new lines");
            File.WriteAllLines(FilePath, TextLines);

            Console.ReadLine();
        }
    }
}
