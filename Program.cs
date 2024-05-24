using System;

public class Program
{
    private const double unitFactor = 2.54;
    public static void Main(String[] args)
    {
        Console.WriteLine("enter inches");
        var inches = 5;
        double centimeters = inches * unitFactor;
        //3 inches is 7.62 centimeters
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}