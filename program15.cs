// write a program to implemewnt the concept of properties
using System;

class Person
{
    // Private field to store the name
    private string name;

    // Property to get and set the name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Auto-implemented property for Age
    public int Age { get; set; }

    // Read-only property for FullName (combines Name with a suffix)
    public string FullName
    {
        get { return $"{Name}, Esq."; }
    }

    static void Main(string[] args)
    {
        Person person = new Person();

        // Using the property to set the name
        person.Name = "Alice";

        // Setting the auto-implemented property for Age
        person.Age = 30;

        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
        Console.WriteLine("Full Name: " + person.Full
