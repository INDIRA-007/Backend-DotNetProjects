using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_program
{
    //single level inheritance
    //class Vehicle //base class
    //{
    //    string number;
    //    string owner;
    //}

    //class Fourwheeler : Vehicle  //derived class
    //{
    //    string type;
    //}

    //multi level inheritance
    //class Vehicle //base class
    //{
    //    string number;
    //    string owner;
    //}
    //class Fourwheeler : Vehicle  //derived class
    //{
    //    string type;
    //}
    //class Car : Fourwheeler  //derived class
    //{
    //    int numberOfDoors;
    //}


    //hierarchical level inheritance
    class Vehicle //base class
    {
        string number;
        string owner;
    }

    class Fourwheeler : Vehicle  //derived class
    {
        string type;
    }
    class Car : Fourwheeler  //derived class
    {
        int numberOfDoors;
    }
    class Tractor : Fourwheeler  //derived class
    {
        int numberOfAxles; 
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
