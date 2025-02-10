// Write a program to show the usage of this keyword
using System;

class Person
{
    private string name;
    private int age;

    // Constructor to initialize the Person object
    public Person(string name, int age)
    {
        // The 'this' keyword is used to refer to the current object's instance variables
        this.name = name;
        this.age = age;
    }

    // Method to display person details
    public void Display()
    {
        // The 'this' keyword is used to refer to the current object's instance variables
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
    }

    // Method to compare two persons
    public bool IsSamePerson(Person otherPerson)
    {
        // 'this' refers to the current object, and 'otherPerson' is the object passed as a parameter
        return this.name.Equals(otherPerson.name) && this.age == otherPerson.age;
    }

    // Main method to test the functionality
    public static void Main(string[] args)
    {
        // Create two Person objects
        Person person1 = new Person("John", 25);
        Person person2 = new Person("Jane", 30);

        // Display details of person1
        person1.Display();
        
        // Display details of person2
        person2.Display();

        // Compare person1 and person2 using the IsSamePerson method
        if (person1.IsSamePerson(person2))
        {
            Console.WriteLine("Both persons are the same.");
        }
        else
        {
            Console.WriteLine("The persons are different.");
        }
    }
}
