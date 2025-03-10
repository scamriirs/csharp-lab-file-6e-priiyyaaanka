// write a program to show concept of method overloading
using System;

class Program
{
    public static void Display(int num)
    {
        Console.WriteLine("Displaying an integer: " + num);
    }

    public static void Display(int num1, int num2)
    {
        Console.WriteLine("Displaying two integers: " + num1 + " and " + num2);
    }

    public static void Display(string message)
    {
        Console.WriteLine("Displaying a message: " + message);
    }

    static void Main()
    {
        Display(5);
        Display(10, 20);
        Display("Hello, World!");
    }
}

