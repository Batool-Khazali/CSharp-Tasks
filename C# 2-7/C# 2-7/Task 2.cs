using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__2_7
{

    // Task 2
    // 1.	Define an Interface
    //     o	Create an interface named ISound that includes a method void MakeSound();.


    public interface ISound
    {
        void MakeSound();
    }


    // 2.	Define an Abstract Class
    //     o	Create an abstract class named Animal that includes:
    //         	A property string Name { get; set; }.
    //         	A constructor that takes a string name parameter and sets the Name property.
    //         	An abstract method void Eat();.
    //         	A concrete method void Sleep() that prints out the animal's name followed by "is sleeping.".


    public abstract class Animal
    {
        string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public abstract void Eat();

        public void sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }


    // 3.	Implement Concrete Classes
    //     o    Create two classes, Dog and Cat, that:
    //         	Inherit from Animal.
    //         	Implement the ISound interface.
    //         	Provide specific implementations for the Eat method that print out the animal's name followed by what it is eating.
    //         	Provide specific implementations for the MakeSound method that print out the animal's name followed by the sound it makes (e.g., "Woof!" for dogs and "Meow!" for cats).


    // using multible inheritace to be able to inherit from 2 different classes at the same time without repeating the derived class

    public class Cat : Animal, ISound
    {
        public string Name { get; set; }

        public Cat(string name) : base(name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fish");
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Dog : Animal, ISound
    {
        public string Name { get; set; }

        public Dog(string name) : base(name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating Meat");
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }


}
