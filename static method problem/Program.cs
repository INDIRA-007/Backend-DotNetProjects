﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public void Main(string[] args)
{
TestStatic t = new TestStatic();
t.Print();
}


public class TestStatic
{
    public static int TestValue;

    public TestStatic()
    {
        if (TestValue == 0)
        {
            TestValue = 5;
        }
    }

    static TestStatic()
    {
        if (TestValue == 0)
        {
            TestValue = 10;
        }

    }

    public void Print()
    {
        if (TestValue == 5)
        {
            TestValue = 6;
        }
        Console.WriteLine("TestValue : " + TestValue);
    }
}

