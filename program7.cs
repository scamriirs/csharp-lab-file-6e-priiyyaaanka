// write a program to find the integer and fractional part of  a number using out keyword 
using System;

class Program
{
    static void GetParts(double number, out int integerPart, out double fractionalPart)
    {
        integerPart = (int)number;
        fractionalPart = number - integerPart;
    }

    static void Main()
    {
        double number;

        Console.Write("Enter a number: ");
        number = Convert.ToDouble(Console.ReadLine());

        int integerPart;
        double fractionalPart;

        GetParts(number, out integerPart, out fractionalPart);

        Console.WriteLine("Integer Part: " + integerPart);
        Console.WriteLine("Fractional Part: " + fractionalPart);
    }
}
