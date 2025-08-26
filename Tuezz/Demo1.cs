using System;

public class Demo1
{
    int x;//private members of class
    int y;

    public Demo1(int x, int y)
    {
        this.x = x; this.y = y;
    }

    public int X
    {
        set { x = value; } //initialize member
        get { return x; }  //read - write program
    }

    public int Y
    {
        set { y = value; }
        get { return y; }
    }
}
internal class PropertyDemo
{
    static void Main(string[] args)
    {
        Demo1 ob = new Demo1(100, 200);
        ob.X = 50;
        Console.WriteLine("Value of private x:" + ob.X);
        ob.Y = 150;
        Console.WriteLine("Value of private y:" + ob.Y);
        Console.WriteLine("Addition of x and y:" + (ob.X + ob.Y));
    }
}















