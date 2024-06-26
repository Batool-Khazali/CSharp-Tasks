using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Wed_26_6
{
    internal class Tasks
    {
        static void Main(string[] args)
        {
            //// In Class Task 1;

            //Console.Write("enter your text: ");
            //string inputText = Console.ReadLine();
            //Console.WriteLine("your text: " + inputText);
            //char lastChar = inputText.Last();
            //string lastChar2 = inputText.Substring(inputText.Length - 1);
            //Console.WriteLine("the last character is: " + lastChar);
            //Console.WriteLine("the last character is: " + lastChar2);

            //Console.WriteLine("");


            //// In Class Task 2;

            //Console.Write("enter your first text: ");
            //string first = Console.ReadLine();
            //Console.Write("enter your second text: ");
            //string second = Console.ReadLine();
            //string textSpace = " ";

            //string conStrng = string.Concat(first, textSpace, second);

            //Console.WriteLine("your text is: " + conStrng);
            //Console.WriteLine("your text is: " + first + textSpace + second);

            //Console.WriteLine("");



            // Task 1;
            // 1.	Write a C# program that accept two integers and display the smaller.

            int num1 = 65;
            int num2 = 31;
            int minimum = Math.Min(num1, num2);
            Console.WriteLine("the smaller number between 65 and 31 is " + minimum);

            int[] numArr = {num1, num2};
            Array.Sort(numArr);
            Console.WriteLine("the smaller number between 65 and 31 is " + numArr[0]);

            Console.WriteLine("");


            // Task 2;
            //2.	 Write a C# conditional statement to find the sign  of input  number. Display sign. 

            int num3 = 7;
            int num4 = -24;
            int sign1 = Math.Sign(num3);
            int sign2 = Math.Sign(num4);
            Console.WriteLine("the sign of 7 is " + sign1); 
            Console.WriteLine("the sign of -24 is " + sign2);

            // Math.Sign gives the sign as 1 or -1. you can have the result as + for the positive number without if statment 
            string sign = Convert.ToString(sign2);
            Console.WriteLine("the sign of -24 is " + sign[0]);

            // the following method was mentioned while discussing the tasks so i tried it. format number to have a sign if > or < than 0. 0 doesn't have a sign in the format i choose
            string sign3 = num3.ToString("+#;-#;0");
            string sign4 = num4.ToString("+#;-#;0");
            Console.WriteLine("the sign of 7 is " + sign3[0]);
            Console.WriteLine("the sign of -24 is " + sign4[0]);


            Console.WriteLine("");



            // Task 3
            //3.	Write a C# conditional statement to sort three numbers ascending. Use console to display the result.

            int num5 = 46, num6 = -37, num7 = 2;
            int[] intArr2 = {num5, num6, num7};
            Array.Sort(intArr2);
            Console.WriteLine("numbers in ascending order " + "[{0}]", string.Join(", ", intArr2));
            Array.Reverse(intArr2);
            Console.WriteLine("numbers in descending order " + "[{0}]", string.Join(", ", intArr2));

            Console.WriteLine("");



            // Task 4;
            //4.	Write a C# conditional statement to find the max of five numbers. Use console to display the result.

            int num8 = 7, num9 = 34, num10 = -24, num11 = -10, num12 = 0;
            int[] intArr3 = { 7, 34, -24, -10, 0 };

            // Math.Max only takes two values
            // without using loop or if, the easiest method and most obvious is sorting the array
            Array.Sort(intArr3);
            int maximum = intArr3[intArr3.Length - 1];
            Console.WriteLine("the biggest number between [7, 34, -24, -10, 0 ] is " + maximum);

            // one of the possiple methods is nesting Math.Max // from stackoverflow
            int maximum2 = Math.Max(num12, Math.Max(num11, Math.Max(num10, Math.Max(num9, num8))));
            Console.WriteLine("the biggest number between [7, 34, -24, -10, 0 ] is " + maximum2);

            // another one from stackoverflow. Enumerable.Max Method it's called i think
            int maximum3 = intArr3.Max();
            Console.WriteLine("the biggest number between [7, 34, -24, -10, 0] is " + maximum3);

            Console.WriteLine("");



            // Task 5;
            // Write a C# program that converts kilometers per hour to miles per hour.  

            Console.Write("enter speed in kph ");
            int kPh = Convert.ToInt32(Console.ReadLine());
            double mPh = kPh * 0.621371;
            Console.WriteLine("converting " + kPh + "kph to mph gives " + mPh + "mph");

            Console.WriteLine("");



            // Task 6;
            // 6.	Write a C# program that takes hours and minutes as input and calculates the total number of minutes.

            Console.Write("enter time in hours ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter time in minutes ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            
            int houtToMin = hours * 60;
            int timeInMin = houtToMin + minutes;
            Console.WriteLine("your time in minutes is " + timeInMin);

            Console.WriteLine("");



            // Task 7;
            // 7.	Write a program in C# that takes minutes as input and display the total number of hours and minutes. 

            Console.Write("enter time in minutes ");
            double minutes2 = Convert.ToDouble(Console.ReadLine());
            double minToHour = minutes2 / 60;
            Console.WriteLine("your time in hours is " + minToHour);

            Console.WriteLine("");



            // Task 8;
            // 8.	Create string of array that contains 5 element of different sentence with different length .
            // Print all elements with fixed length for each sentence.

            // if i understood the question correctly, the task needs a string array with sentences as values, then print each sentence but stop at a specified length

            string[] sentences = { "Hello, World!", "Don\'t stop trying", "Orange Coding Academy", "Strength begins in understanding your own weakness", "There\'s no time like the present" };
            Console.Write("how long do you want the sentence to be (max is 13): ");
            int senLen = Convert.ToInt32(Console.ReadLine());

            string sen1 = sentences[0].Substring(0, senLen);
            string sen2 = sentences[1].Substring(0, senLen);
            string sen3 = sentences[2].Substring(0, senLen);
            string sen4 = sentences[3].Substring(0, senLen);
            string sen5 = sentences[4].Substring(0, senLen);
            Console.WriteLine("the first sentence is \" " + sen1 + " \"");
            Console.WriteLine("the second sentence is \" " + sen2 + " \"");
            Console.WriteLine("the third sentence is \" " + sen3 + " \"");
            Console.WriteLine("the fourth sentence is \" " + sen4 + " \"");
            Console.WriteLine("the fifth sentence is \" " + sen5 + " \"");



        }
    }
}
