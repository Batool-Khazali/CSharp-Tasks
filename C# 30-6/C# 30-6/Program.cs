using System;
using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace C__30_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            // Write a function in C# that accept 10 numbers and return sum and average.
            // the function can be found in this class

            Console.Write("enter 10 numbers seperated by comma: ");
            string numbers = Console.ReadLine();
            string[] numbersStringArr = numbers.Replace(" ", "").Split(',');
            double[] numbersArr = Array.ConvertAll(numbersStringArr, s => double.Parse(s));

            SumAndAverage(numbersArr);


            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            // Task 2
            // Write a program in C to display the cube of the number up to given an integer.
            // the program can be found in a different class

            Console.Write("enter a number to find its cube: ");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            double resultCube = CubicNumber.cubedNumber(inputNumber);
            Console.WriteLine($"the cube of {inputNumber} is {resultCube}");


            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            // Task 3
            // Write a program in C# return only numbers in the years array greater than 1950.
            // the program can be found in a different class

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            Console.WriteLine($"the years above 1950 in the array [{string.Join(", ", years)}] are ");
            YearsAbove1950.getYears(years);
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            // Task 4 
            // Create a function that takes the age in years and returns the age in days.

            Console.Write("enter your age in years to find your age in days: ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your age in days is {YearsToDays(inputAge)}");


            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            // Task 5
            // 5-	Create class that contain the following field:
            // a.Age  between 18 - 60
            // b.Gender
            // c.Name
            // d.E - Mail
            // e.ID
            // f.Phoneshould be started in 077 or 078 or 079
            // Don’t forget the default value.

            PersonalInformation userInfo = new PersonalInformation("Alice", 25, "female", 207104, "alice@pandora.com", 0789123456);

            Console.WriteLine($"name: {userInfo.userName} \n age: {userInfo.userAge} \n gender: {userInfo.userGender} \n ID: {userInfo.userId} \n E-mail: {userInfo.userEmail} \n phone: {userInfo.userPhone} ");

            Console.ReadKey();


        }

        public static void  SumAndAverage(double[] x) 
        {
            double sum = 0;
            double average = 0;

            foreach (var num in x)
            {
                sum += num;
            }
            average = sum / x.Length;

            Console.WriteLine($"the sum of your numbers is {sum} and the the average is {average}");
        }

        public static int YearsToDays(int age)
        {
            int ageInDays = age * 365;
            int leapYears = ageInDays / 4;
            ageInDays += leapYears;
            return ageInDays;
        }

    }

    public class CubicNumber
    {
        public double num;
        public double numberCube;

        public static double cubedNumber(double num)
        {
            double numberCube = num * num * num;
            return numberCube;
        }
    }

    public class YearsAbove1950
    {
        public int[] yearsArr;

        public static void getYears(int[] year)
        {
            for (int y = 0; y < year.Length; y++) 
            {
                if (year[y] >= 1950)
                {
                 Console.Write(year[y] + ", ");
                }
            }
        }

    }

    public class PersonalInformation
    {
        public string userName;
        public int userAge;
        public string userGender;
        public int userId;
        public string userEmail;
        public string userPhone; // string so that i can add the 0 at the start

        public PersonalInformation(string name, int age, string gender, int id, string email, int phone) 
        {
            userName = name;
            userAge = checkAge(age);
            userGender = gender;
            userId = id;
            userEmail = checkEmail(email);
            userPhone = "0" + checkPhone(phone); // add the 0 at the strat
        }

        public int checkAge(int age) 
        {
            if (age > 18 && age < 60)
            {
                return age;
            }
            else
            {
                throw new ArgumentException("age must be between 18 and 60");
            }
        }

        public string checkEmail(string email) 
        {
            string emailRegix = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            if (Regex.IsMatch(email, emailRegix))
            {
                return email;
            }
            else
            {
                throw new ArgumentException("enter your email correctly");
            }
        }

        public int checkPhone(int phone)
        {
            // removing 0 from the start of the regex because converting the number to string does so too
            string phoneRegix = @"^(77|78|79)[0-9]{7}$";
            string phoneStr = phone.ToString().Trim();

            if (Regex.IsMatch(phoneStr, phoneRegix))
            {
                return phone;
            }
            else
            {
                throw new ArgumentException("enter your phone correctly");
            }
        }
    }

}
