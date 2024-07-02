using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            // 5.   create  a BMW Class  inherit from Car Class 
            //         b-  create object from  BMW then call the function Display


            Car bmw = new BMW();
            bmw.Display();

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            // Task 2
            // 4.	Create a Program to Test Your Classes
            //     o	In the Main method, create instances of Dog and Cat.
            //     o    Call the Eat, Sleep, and MakeSound methods on each instance.

            Cat myCat = new Cat("Cindy");
            myCat.Eat();
            myCat.sleep();
            myCat.MakeSound();

            Console.WriteLine();

            Dog aDog = new Dog("Bud");
            aDog.Eat();
            aDog.sleep();
            aDog.MakeSound();

        }
    }
}
