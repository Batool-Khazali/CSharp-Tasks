using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__27_6
{
    internal class Tasks
    {
        static void Main(string[] args)
        {

            //Task 1
            // 1-	Correct the syntax error:

            //•	string[] ARR = [1, 7  9  45,]
            // the variable type and data type do not match. either change "string" to "int" or add "" for each value in the array to change its type into a string.
            // in c#, arrays values are written between curly brackets only, not square brackets. change the brackets to {}.
            string[] ARR1 = { "1", "7", "9", "45" };
            int[] ARR2 = { 1, 7, 9, 45 };

            //•	int arr2 = ["Str" "alex","moh"
            // the variable type and data type do not match. change "int" to "string".
            // in c#, arrays values are written between curly brackets only, not square brackets. change the brackets to {}.
            // array brackets should be  closed on both ends.
            // each value must be seperated with a comma.
            string[] arr2 = { "Str", "alex", "moh" };

            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            // the variable type and data type do not match. single quotes are used for char data type values and double quotes are used for string data type values. change the single quotes to double quotes.
            // to indecate that the variable is an array, you must add [] to the variable type.
            // in c#, arrays values are written between curly brackets only, not square brackets. change the brackets to {}.
            // array brackets should be  closed on both ends.
            // each value must be seperated with a comma.
            // it's better to remove the comma after the value, but it doesn't give an error.
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };



            // Task 2
            //2-	What the index of "Banana","Tomato"?
            // i tried different methods, especially, the ones i\m not used to
            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            // method 1 wothout loops
            int tomatoIndex = Array.IndexOf(fruits, "Tomato");
            Console.WriteLine("the index of \"Tomato\" in the array is " + tomatoIndex);
            int bananaIndex = Array.IndexOf(fruits, "Banana");
            Console.WriteLine("the index of \"Banana\" in the array is " + bananaIndex);

            // method 2 with foreach
            foreach (var a in fruits)
            {
                if (a == "Banana")
                {
                    Console.WriteLine("the index of \"Banana\" in the array is " + Array.IndexOf(fruits, a));

                }
                else if (a == "Tomato")
                {
                    Console.WriteLine("the index of \"Tomato\" in the array is " + Array.IndexOf(fruits, a));

                }
            }


            // method 3 with for and switch
            for (int i = 0; i < fruits.Length; i++)
            {
                switch (fruits[i])
                {
                    case "Banana":
                        Console.WriteLine("the index of \"Banana\" in the array is " + i);
                        break;
                    case "Tomato":
                        Console.WriteLine("the index of \"Tomato\" in the array is " + i);
                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();



            // Task 3 
            // 3-	Create an multiple arrays that represents your:
            // •	Favorite Food(5 item)
            // •	Favorite Sport(3 item)
            // •	Favorite Movie(4 item)
            // Then, print each array using foreach, and Loop Through an Array

            string[] favFood = { "melons", "fig", "mullberry", "fatoosh", "khobs be basal" };
            string[] favSport = { "archary", "skating", "gymnastics" };
            string[] favMovie = { "Lord of the rings", "Patema Inverted", "narnia", "Puella Magi Madoka Magica Movies" };
            char space = ' ';

            Console.Write("my favorite foods are: ");
            foreach (var food in favFood)
            {
                Console.Write(food + space);
            }
            Console.WriteLine();

            Console.Write("my favorite sports are: ");
            foreach (var sport in favSport)
            {
                Console.Write(sport + space);
            }
            Console.WriteLine();

            Console.Write("my favorite movies are: ");
            foreach (var movie in favMovie)
            {
                Console.Write(movie + space);
            }

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();



            // Task 4
            //4-	Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma

            Console.Write("enter 3 numbers seperater by a comma: ");
            string numbers = Console.ReadLine();

            // use replace to remove any withespace then split the string on the comma. i tried using .trim for each value inside the array, but it kept giving me errors
            string[] numbersArr = numbers.Replace(" ", "").Split(',');

            double sum = 0;
            foreach (var number in numbersArr)
            {
                double num = Convert.ToDouble(number);
                sum += num;
            }
            Console.WriteLine("the sum of your numbers is: " + sum);

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(); ;




            // Task 5
            // 5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ].
            // the n terms of odd numbers (from what i understood) is the index of the odd number between the odd numbers.
            // for example: the odd numbers are [1,3,5,7,...], the nth term of 5 is 3,  and 7 is 4, and so on

            // i used arrays to solve this

            int sum2 = 0;
            // an empty array with length of 50 which is the expected numbers to be in the array (100/2). using less would give an error (exceding array limit), and using more would fill the rest of the array with 0s
            int[] oddNumbers = new int[50]; 
            int[] nthTerm = new int[50];
            int index = 0; // the index for the arrays

            for (int i = 1 ; i < 100; i = i+2)
            {
                oddNumbers[index] = i;
                nthTerm[index] = index + 1;
                index++;
                sum2 += i;
            }


            Console.WriteLine("the odd numbers between 1 and 100 are: " + string.Join("\t", oddNumbers));
            Console.WriteLine();
            Console.WriteLine("the nth term for each odd number is:   " + string.Join("\t", nthTerm));
            Console.WriteLine();
            Console.WriteLine("the sum of the odd numbers is:   " + sum2);
            Console.WriteLine();

            // without array it would be
            int sum3 = 0;
            int index2 = 0;
            Console.WriteLine("the odd number from 1 to 100 and their nth term is: \n");

            for (int l = 1; l < 100; l = l+2)
            {
                index2 += 1;
                Console.WriteLine($"odd numer {l} and its nth term {index2}");
                sum3 += l;
            }
            Console.WriteLine();
            Console.WriteLine("the sum of the odd numbers is:   " + sum3);


            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();




            // Task 6
            // 6-	Write a program in C## to display the pattern like right angle triangle using an asterisk.

            Console.Write("how many lines do you wants? ");
            int tall = Convert.ToInt32(Console.ReadLine());

            // nested loop because we are changing both horizental and vertical
            for (int h = 1; h <= tall; h++)
            {
                for (int v = 0; v <= h; v++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();




            // Task 7
            // Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            // The pattern like:
            // 1
            // 2 3
            // 4 5 6
            // 7 8 9 10

            Console.Write("how many lines do you wants? ");
            int lines = Convert.ToInt32(Console.ReadLine());

            // the displayNum is declared outside and its value changed inside the nested loop
            int displayNum = 0;

            for (int h = 0; h < lines; h++)
            {
                for (int v = 0; v <= h; v++)
                {
                    displayNum += 1;
                    Console.Write(displayNum + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


        }
    }
}
