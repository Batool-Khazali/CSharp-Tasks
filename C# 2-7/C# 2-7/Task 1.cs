using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__2_7
{

    // Task 1
    // 1.	Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
    // 2.	Create function name DisplayInfo take two parameters	(make, year)
    // 3.	Create function name DisplayInfo take one parameters	(make)
    // 4.	This class contain function name (Display) that print statement (Welcome Car)
    // 5.   create  a BMW Class  inherit from Car Class 
    //         a.	This class contain function name (Display) that print statement (welcome BMW)
    //         b-  create object from  BMW then call the function Display
    // 6.   repeat  step 4 , 5 with Overriding Concept.


    public class Car
    {
        public string Maker { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public int PalletNumber { get; set; }
        public string Color { get; set; }

        public void DisplayInfo(string maker, int year)
        {
            Console.WriteLine($"i saw a {year} {maker} yesterday");
        }
        public void DisplayInfo(string maker)
        {
            Console.WriteLine($"i saw a {maker} yesterday");
        }

        public void Display()
        {
            Console.WriteLine("Welcome Car");
        }

        //public virtual void Display()
        //{
        //    Console.WriteLine("Welcome Car");
        //}
    }

    public class BMW : Car
    {
        public void Display()
        {
            Console.WriteLine("Welcome BMW");
        }

        //public override void Display ()
        //{
        //    Console.WriteLine("Welcome BMW");
        //}

    }

}
