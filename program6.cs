// Write a program to find square of a number using pass by reference
using System;

class Program
{
    // Function to calculate the square of a number using pass by reference
    static void Square(ref int num)
    {
        num = num * num;  // Modify the value of num directly
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Square(ref number);  // Pass by reference

        Console.WriteLine("The square of the number is: " + number);
    }
}
