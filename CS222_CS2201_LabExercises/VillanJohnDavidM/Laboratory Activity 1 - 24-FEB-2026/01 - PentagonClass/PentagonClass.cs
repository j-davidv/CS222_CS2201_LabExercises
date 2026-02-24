using System;

public class Pentagon
{
    private double side;

    public Pentagon()
    {
        this.side = 0;
    }

    public Pentagon(double side)
    {
        this.side = side;
    }

    public double GetPerimeter()
    {
        return 5 * this.side;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4.0;
    }

    public void Display()
    {
        Console.WriteLine($"Side Length: {this.side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }
}

public class PentagonClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        Pentagon p1 = new Pentagon();
        p1.Display();
        Console.WriteLine();

        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-------------------------");
        Pentagon p2 = new Pentagon(5);
        p2.Display();
        Console.WriteLine();
    }
}


        