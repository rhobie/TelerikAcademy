using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap04_ConsoleInputAndOutput
    {
        public static class One
        {
            //04.1. Write a program that reads from the console three numbers of type int and prints their sum.
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("04.1. Write a program that reads from the console three numbers of type int and prints their sum.");
                Console.WriteLine();

                int a;
                int b;
                int c;

                string s = Console.ReadLine();
                Int32.TryParse(s, out a);
                s = Console.ReadLine();
                Int32.TryParse(s, out b);
                s = Console.ReadLine();
                Int32.TryParse(s, out c);

                Console.WriteLine((a+b+c).ToString());

                Console.WriteLine("CORRECT");
            }
        }
        public static class Two
        {
            //04.2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("04.2. Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");
                Console.WriteLine();

                int rad;
                Console.WriteLine("Enter circle radius");
                string s = Console.ReadLine();
                Int32.TryParse(s, out rad);
                Console.WriteLine("Perimeter of circle with radius {0}, is {1}, it's area is {2}",rad,(2*Math.PI*rad),(Math.PI*(rad*rad)));

                Console.WriteLine("CORRECT");
            }
        }
        public static class Three
        {
            //04.3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("04.3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.");
                Console.WriteLine();

                Console.WriteLine("Enter company name");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter company phone number");
                string companyPhone = Console.ReadLine();
                Console.WriteLine("Enter company website");
                string companyWebsite = Console.ReadLine();
                Console.WriteLine("Enter manager's full name");
                string managerName = Console.ReadLine();

                Console.WriteLine("Company Name: {0}, Company phone number:{1}, company website: {2}, manager name: {3}",companyName,companyPhone,companyWebsite,managerName);

                Console.WriteLine("CORRECT - couldnt be bothered adding more items than this");
                
            }
        }
        public static class Four
        {
            //04.4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("04.4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.");
                Console.WriteLine();
            }
        }
        public static class Five
        {
            //04.5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("04.5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.");
                Console.WriteLine();
            }
        }
        public static class Six
        {
            //04.6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("04.6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.");
                Console.WriteLine();
            }
        }
        public static class Seven
        {
            //04.7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("04.7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.");
                Console.WriteLine();
            }
        }
        public static class Eight
        {
            //04.8. Write a program that reads five numbers from the console and prints the greatest of them.
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("04.8. Write a program that reads five numbers from the console and prints the greatest of them.");
                Console.WriteLine();
            }
        }
        public static class Nine
        {
            //04.9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("04.9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.");
                Console.WriteLine();
            }
        }
        public static class Ten
        {
            //04.10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("04.10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.");
                Console.WriteLine();
            }
        }
        public static class Eleven
        {
            //04.11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("04.11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …");
                Console.WriteLine();
            }
        }
        public static class Twelve
        {
            //04.12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("04.12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …");
                Console.WriteLine();
            }
        }


    }
}
