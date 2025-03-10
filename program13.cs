// write a program to show the concept of method overriding
using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        myAnimal.Sound();  // Calls the base class method
        myDog.Sound();     // Calls the overridden method in Dog class
        myCat.Sound();     // Calls the overridden method in Cat class
    }
}


        myAnimal.Sound();  // Calls the base class method
        myDog.Sound();     // Calls the overridden method in Dog class
        myCat.Sound();     // Calls the overridden method in Cat class
    }
