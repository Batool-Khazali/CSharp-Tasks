using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tasks_25_6_Tue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Please enter your text here ");
            string inputText = Console.ReadLine();
            Console.WriteLine("You have written : " + inputText);
            Console.WriteLine("");


            //Task 2

            string text = "Rose";
            int num = 58;
            double num2 = 16.4d;
            bool right = true;
            char one = 'J';

            Console.WriteLine(text);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(right);
            Console.WriteLine(one);
            Console.WriteLine("");


            //Task 3

            string[] cars = { "BMW", "Ford", "Volkswagen", "Mercedes-Benz", "Kia", "TOYOTA" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[5]);
            Console.WriteLine(cars.Length);
            Console.WriteLine("");


            //Task 4

            Console.Write("Input your firstname: ");
            string fName = Console.ReadLine();

            Console.Write("Input your lastname: ");
            string lName = Console.ReadLine();

            Console.Write("Input your year of birth: ");
            string birthYear = Console.ReadLine();

            Console.WriteLine(fName + " " + lName + " " + birthYear);
            Console.WriteLine("");


            //Task 5

            int[] numbers = new int[10];

            numbers[0] = 1;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 4;
            numbers[5] = 5;
            numbers[6] = 6;
            numbers[7] = 7;
            numbers[8] = 8;
            numbers[9] = 9;

            Console.Write("Elements in array are: ");
            Console.Write(numbers[0]);
            Console.Write(" ");
            Console.Write(numbers[1]);
            Console.Write(" ");
            Console.Write(numbers[2]);
            Console.Write(" ");
            Console.Write(numbers[3]);
            Console.Write(" ");
            Console.Write(numbers[4]);
            Console.Write(" ");
            Console.Write(numbers[5]);
            Console.Write(" ");
            Console.Write(numbers[6]);
            Console.Write(" ");
            Console.Write(numbers[7]);
            Console.Write(" ");
            Console.Write(numbers[8]);
            Console.Write(" ");
            Console.WriteLine(numbers[9]);

            Console.WriteLine("Elements in array are: " + numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3] + " " + numbers[4] + " " + numbers[5] + " " + numbers[6] + " " + numbers[7] + " " + numbers[8] + " " + numbers[9]);

            Console.WriteLine("Elements in array are: " + "[{0}]", string.Join(", ", numbers)); // this was from 
            Console.WriteLine(string.Join("\n", numbers));
            Console.WriteLine("");



            //Task 6

            int[] numSum = { 2, 5, 8 };
            int sum = numSum[0] + numSum[1] + numSum[2];

            Console.WriteLine(sum);
            Console.WriteLine(numSum[0] + numSum[1] + numSum[2]);
            Console.WriteLine("");

        }
    }
}
