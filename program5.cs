// Write a program to find the square of a number using pass by value]
using System;

class Program
{
    // Method with pass-by-value parameter
    static void ModifyValue(int num)
    {
        num = num + 10;
        Console.WriteLine("Inside ModifyValue method: " + num);
    }

    static void Main()
    {
        int value = 5;
        Console.WriteLine("Before ModifyValue method: " + value);
        
        // Pass the value of 'value' to the method
        ModifyValue(value);
        
        // 'value' remains unchanged outside the method
        Console.WriteLine("After ModifyValue method: " + value);
    }
}
