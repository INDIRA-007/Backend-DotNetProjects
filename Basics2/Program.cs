using System;
using System.Runtime.InteropServices;

namespace Basics2
{
    public class Program
    {

        ////---------FUNCTION---------

        //public static void SayHello()
        //{
        //    string name = "";
        //    Console.Write("What is your name: ");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Hello {0}", name);
        //}

        //static void DoubleIt(int x, out int solution)
        //{
        //    solution = x * 2;
        //}

        //public static void Swap(ref int num3, ref int num4)
        //{
        //    int temp = num3;
        //    num3 = num4;
        //    num4 = temp;
        //}

        //public static double GetSumMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach (int i in nums)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //static void PrintInfo(string name, int zipCode)
        //{
        //    Console.WriteLine("{0} lives in the xip code {1}", name, zipCode);

        //}

        ////METHOD OVERLOADING
        //static double GetSum2(double x = 1, double y=1)
        //{
        //return x + y;
        //}

        //static double GetSum2(string x = "1", string y = "1")
        //{
        //    double dblx = Convert.ToDouble(x);
        //    double dbly = Convert.ToDouble(y);

        //    return dblx + dbly;
        //}

        //static void PaintCar(carColor cc)
        //{
        //    Console.WriteLine("The car was painted {0} with the code {1}",
        //        cc,(int)cc);
        //}

        ////--------END OF FUNCTION--------

        /// <summary>
        ////Enumerator
        /// </summary>
        //enum carColor : byte
        //{
        //    Orange = 1,
        //    Blue,
        //    Green,
        //    Red,
        //    Yellow
        //}

        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l; width = w;
            }

            public double Area()
            {
                return length * width;
            }

        }

        static void Main(string[] args)
        {
            //SayHello();

            //int solution;
            //DoubleIt(15, out solution);
            //Console.WriteLine("15 * 2 = {0}", solution);

            //int num3 = 10;
            //int num4 = 20;
            //Console.WriteLine("Before swap num1 : {0} num2 : {1} ",
            //    num3, num4);
            //Swap(ref num3, ref num4);
            //Console.WriteLine("After swap num1 : {0} num2 : {1} ",
            //    num3, num4);


            //Console.WriteLine(" 1+2+3 = {0}", GetSumMore(1, 2, 3));

            //PrintInfo(zipCode: 15475, name: "Indira Mary");

            //Method Overloading
            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.5));
            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.5"));

            ////DateTime / TimeSpan
            //DateTime awesomeDate = new DateTime(1974, 12, 21);
            //Console.WriteLine("Day of the week : {0}",
            //    awesomeDate.DayOfWeek);
            //awesomeDate = awesomeDate.AddDays(4);
            //awesomeDate = awesomeDate.AddMonths(1);
            //awesomeDate = awesomeDate.AddYears(1);
            //Console.WriteLine("New Date : {0}",
            //    awesomeDate.Date);

            //TimeSpan lunchTime = new TimeSpan(12, 20, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0,15, 0));
            //Console.WriteLine("New Time : {0}",
            //    lunchTime.ToString());

            //carColor car1 = carColor.Blue; 
            //PaintCar(car1);


            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}",
                rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}",
                rect2.length);



        }
            
        

    }
}