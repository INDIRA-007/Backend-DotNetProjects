using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;

namespace Basic
{
    public class Program
    {

        // ---------Functions-----------
        //static void PrintArray(int[] intArray, string mess)
        //{
        //    foreach(int k in intArray)
        //    {
        //        Console.WriteLine("{0} : {1}", mess, k);
        //    }
        //}

        static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;

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

            //string randString = "This is a string";
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

            //----------multidimentional array----------------

            //string[,] custName = new string[2, 2] { { "Bob", "Smaith"},
            //    {"Sally", "Smith" }};
            //Console.WriteLine("MD Value : {0}", custName.GetValue(1, 0));

            //for(int i=0; i < custName.GetLength(0); i++)
            //{
            //    for(int j=0; j < custName.GetLength(0); j++)
            //    {
            //        Console.WriteLine("{0} ", custName[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] randNums = { 1, 4, 9, 2 };

            //PrintArray(randNums, "ForEach");
            //Console.WriteLine("_______________________");

            //Array.Sort(randNums);
            //Array.Reverse(randNums);
            //Console.WriteLine("1 at index : {0}",
            //    Array.IndexOf(randNums, 1));
            //randNums.SetValue(0, 1);
            //int[] srcArray = { 1, 2, 3 };
            //int[] destArray = new int[2];
            //int startInt = 0;
            //int length = 2;
            ////Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            //Array.Copy(srcArray, startInt, destArray, 0, length);
            //PrintArray(destArray, "Copy");

            //Array anotherArray = Array.CreateInstance(typeof(int), 10);
            //srcArray.CopyTo(anotherArray, 5);

            //foreach(int n in anotherArray)
            //{
            //    Console.WriteLine("CopyTo : {0} ", n);
            //}

            //int[] numArray = { 1, 11, 22 };
            ////Console.WriteLine("> 10 : {0}", Array.Find(numArray,GT10));
            ///

            //// statements
            ////Relational Operators : > < >= <= == !=
            ////Logical Operators : && || !
            //    int age = 17;
            //    if ((age >= 5) && (age <= 7))
            //    {
            //        Console.WriteLine("Go to Elementary school");
            //    }
            //    if ((age >= 7) && (age <= 13))
            //    {
            //        Console.WriteLine("Go to Middle school");
            //    }
            //    if ((age >= 13) && (age <= 19))
            //    {
            //        Console.WriteLine("Go to High school");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Go to College");
            //    }
            //    if((age < 14) || (age > 67))
            //    {
            //        Console.WriteLine("to shouldn't work");
            //    }
            //    Console.WriteLine("! true = " + (!true));

            //    //ternary operator
            //    bool canDrive = age >= 16 ? true : false;

            //    switch(age)
            //    {
            //        case 1: 
            //        case 2:
            //            Console.WriteLine("Go to Day Care");
            //            break;

            //        case 3:
            //        case 4:
            //            Console.WriteLine("Go to Preschool");
            //            break;

            //        case 5:
            //            Console.WriteLine("Go to kindergarten");
            //            break;
            //        default:
            //            Console.WriteLine("Go to another school");
            //            goto OtherSchool;

            //    }
            //OtherSchool:
            //    Console.WriteLine("Elementary, Middle, High School");

            //    string name2 = "Derek";
            //    string name3 = "Derek";
            //    if(name2.Equals(name3, StringComparison.Ordinal))
            //    {
            //        Console.WriteLine("Names are equal");
            //    }


            //int i = 1;
            //while(i<=10)
            //{
            //    if(i % 2 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 9)
            //        break;
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1,11);
            //int numberGuessed = 0;
            //Console.WriteLine("Random Num : ", secretNumber);

            //do
            //{
            //    Console.WriteLine("Enter a number between 1 & 10 : ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());

            //}while(secretNumber != numberGuessed);

            //Console.WriteLine("You guessed it was {0}", secretNumber);

            ////Exception handling

            //double num1 = 5;
            //double num2 = 0;

            //try
            //{
            //    Console.WriteLine("5 / 0 = {0}",
            //        DoDivision(num1, num2));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("you can't divide by zero");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Cleaning UP");
            //}

            ////String builders

            //StringBuilder sb = new StringBuilder("Random Text");
            //StringBuilder sb2 = new StringBuilder("More stuff that is very important Text", 256);

            //Console.WriteLine("Capacity : {0}",sb2.Capacity);
            //Console.WriteLine("Capacity : {0}", sb2.Length);
            //sb2.AppendLine("\nMore important text");
            //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            //string bestCust = "Bob Smith";
            //sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            //Console.WriteLine(sb2.ToString());
            //sb2.Replace("text", "characters");
            //Console.WriteLine(sb2.ToString());
            //sb2.Clear();
            //sb2.Append("Random Text");
            //Console.WriteLine(sb.Equals(sb2));
            //sb2.Insert(11, "that's great");
            //Console.WriteLine(sb2.ToString());
            //sb2.Remove(11, 7);
            //Console.WriteLine(sb2.ToString());




        }
    }
}