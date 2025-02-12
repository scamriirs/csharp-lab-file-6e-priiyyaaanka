// Create a program to add the elements in a 2D matrix
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int sum = 0;
        foreach (var item in matrix) sum += item;
        Console.WriteLine(sum);
    }
}
