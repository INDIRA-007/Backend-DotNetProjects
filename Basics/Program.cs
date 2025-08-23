using System;

namespace Basic
{
    public class Program
    {

        // ---------Functions-----------
        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }


        // ---------End of Functions------------
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //Console.WriteLine("Biggest Long {0}", Double.MaxValue);
            //double dblPiVal = 3.14159265358979;
            //double dblBigNum = 3.00000000000002;
            //Console.WriteLine("DBL : PI + bigNum = {0}",
            //    dblPiVal +  dblBigNum);

            //Console.WriteLine("Biggest Float: {0}, ", float.MaxValue);
            //double fltPiVal = 3.141592F;
            //double fltBigNum = 3.000002F;
            //Console.WriteLine("FLT : PI + bigNum = {0}",
            //    fltPiVal + fltBigNum);

            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double dblFromStr = double.Parse("1.340");

            //string strVal = dblFromStr.ToString();
            //Console.WriteLine($"Data type: {strVal.GetType()}");

            ////casting - explict conversion
            //double dblNum = 12.345;
            //Console.WriteLine($"Interger: {(int)dblNum}");

            ////implicit conversion
            //int intNum = 10;
            //long longNum = intNum;
            //Console.WriteLine($"Long :{longNum}");

            //Console.WriteLine("Currency : {0:c}", 23.455);
            //Console.WriteLine("Pad with 0s : {0:d4}", 23);
            //Console.WriteLine("3 Decimals : {0:f3}", 32.45555500);
            //Console.WriteLine("Commas : {0:n4}", 23000);

            string randString = "This is a string";
            //Console.WriteLine("String Length : {0}",
            //    randString.Length);
            //Console.WriteLine("String Contains is : {0}",
            //    randString.Contains("is"));
            //Console.WriteLine("Index of is : {0} ",
            //    randString.IndexOf("is"));
            //Console.WriteLine("Remove String : {0} ",
            //    randString.Remove(10, 6));
            //Console.WriteLine("Insert String : {0}",
            //    randString.Insert(10, "short"));
            //Console.WriteLine("Replace String : {0}",
            //    randString.Replace("string", "sentence"));
            //Console.WriteLine("Compare A to B : {0}",
            //    String.Compare("A", "B",
            //    StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine("A = a : {0}",
            //    String.Equals("A", "a",StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad left : {0}",
            //    randString.PadLeft(20,'.'));
            //Console.WriteLine("Pad Right : {0}",
            //    randString.PadRight(20, '.'));
            //Console.WriteLine("Trim : {0}",
            //    randString.Trim());
            //Console.WriteLine("Uppercase : {0}",
            //    randString.ToUpper());
            //Console.WriteLine("Lowercase : {0}",
            //    randString.ToLower());
            //string newString = String.Format("{0} saw a {1} {2} in the {3}",
            //    "Paul", "rabbit", "eating", "field");
            //Console.Write(newString + "\n");

            ////escape character = \' \" \\ \t \a 
            //Console.WriteLine(@"Exactly what i typed\n");

            //Array
            //int[] favNums = new int[3];
            //favNums[0] = 23;
            //Console.WriteLine("favNum 0 : {0}", favNums[0]);

            //string[] customers = { "Bob", "Sally", "Sue" };
            //var employees = new[] { "Mike", "Paul", "Rike" };

            ////array of base objects - with different data types
            ////
            //object[] randomArray = { "Paul", 45, 1.234 };
            //Console.WriteLine("randomArray 0 : {0}",
            //    randomArray[0].GetType());

            //Console.WriteLine("Array Size : {0}", randomArray.Length);
            //for(int j=0; j < randomArray.Length; j++)
            //{
            //    Console.WriteLine("Array : {0} : value : {1}",
            //        j, randomArray[j]);
            //}

            //multidimentional array

            string[,] custName = new string[2, 2] { { "Bob", "Smaith"},
                {"Sally", "Smith" }};
            Console.WriteLine("MD Value : {0}", custName.GetValue(1, 0));

            for(int i=0; i < custName.GetLength(0); i++)
            {
                for(int j=0; j < custName.GetLength(0); j++)
                {
                    Console.WriteLine("{0} ", custName[i, j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };

            PrintArray(randNums, "ForEach");
            Console.WriteLine("_______________________");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0}",
                Array.IndexOf(randNums, 1));
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInt = 0;
            int length = 2;
            //Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            Array.Copy(srcArray, startInt, destArray, 0, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach(int n in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", n);
            }

            int[] numArray = { 1, 11, 22 };
            //Console.WriteLine("> 10 : {0}", Array.Find(numArray,GT10));

        }
    }
}