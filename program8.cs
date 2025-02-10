// write a program to find smallest array in a program
using System;

class Program
{
    static void Main()
    {
        // Sample array
        int[] numbers = { 45, 22, 78, 15, 89, 10, 56 };

        // Call the function to find the smallest element
        int smallest = FindSmallest(numbers);

        // Output the smallest element
        Console.WriteLine("The smallest element in the array is: " + smallest);
    }

    // Function to find the smallest element
    static int FindSmallest(int[] array)
    {
        int smallest = array[0];  // Assume the first element is the smallest

        // Loop through the array to find the smallest element
        foreach (int num in array)
        {
            if (num < smallest)
            {
                smallest = num;  // Update smallest if a smaller element is found
            }
        }

        return smallest;
    }
}
