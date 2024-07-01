using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C__1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 
            // 1.   Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
            // 2.   Implement a constructor for the car class which takes parameters corresponding to each of the fields above and constructs an object with these values
            // 3.   Implement a method to start and stop engine.
            // 4.	Try to return a string containing full information about the car
            // 5.	Apply inheritance for the base class (create class BMW(Derived Class))
            // 6.	Apply to access the  Derived Class


            Car defult = new Car();
            Console.WriteLine(defult.printCarSale());
            defult.startEngine();
            defult.stopEngine();

            Console.WriteLine();

            BMW newCar = new BMW("BMW", 2020, "Sedan", 40000, "3 Series", 987654, "White");
            Console.WriteLine(newCar.printCarSale());
            newCar.startEngine();
            newCar.stopEngine();

            Console.WriteLine();





        }
    }

}
