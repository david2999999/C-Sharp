﻿struct MyStruct
{
    //Fields
    private int x, y;
    private AnotherClass myClass;
    private Days myDays;

    //Constructor
    public MyStruct(int a, int b, int c)
    {
        myClass = new AnotherClass();
        myClass.number = a;
        x = b;
        y = c;
        myDays = Days.Mon;
    }

    //Method
    public void PrintStatement()
    {
        Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
    }
}