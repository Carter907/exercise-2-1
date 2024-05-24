using System;

public class Program
{

    public static void Main(String[] args)
    {
        double unitFactor = 2.54;
        var inches = 15994;
        double centimeters = inches * unitFactor;
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}
