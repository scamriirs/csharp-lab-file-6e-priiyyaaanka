// Create a program to show the concept of method overloading
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Add(5, 10));
        Console.WriteLine(Add(5.5, 10.5));
        Console.WriteLine(Add("Hello ", "World"));
    }

    static int Add(int a, int b) => a + b;
    static double Add(double a, double b) => a + b;
    static string Add(string a, string b) => a + b;
}
