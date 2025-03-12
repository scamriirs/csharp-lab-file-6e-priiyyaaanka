// write a program to show the concept of indexer
using System;

class SampleCollection
{
    private string[] items = new string[10];

    // Indexer to access the array
    public string this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        SampleCollection collection = new SampleCollection();

        // Using the indexer to set values
        collection[0] = "Hello";
        collection[1] = "World";

        // Using the indexer to get values
        Console.WriteLine(collection[0]); // Output: Hello
        Console.WriteLine(collection[1]); // Output: World
    }
}
