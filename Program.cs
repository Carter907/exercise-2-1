﻿using System;

public class Program
{
    private const double unitFactor = 2.54;
    public static void Main(String[] args)
    {
        Console.WriteLine("enter inches");
        var inches = -15;
        double centimeters = inches * unitFactor;
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}
