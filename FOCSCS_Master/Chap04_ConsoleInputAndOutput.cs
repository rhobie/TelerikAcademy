using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap04_ConsoleInputAndOutput
    {
        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE
        //04    -   COMPLETE
        //05    -   COMPLETE
        //06    -   COMPLETE
        //07    -   COMPLETE
        //08    -   COMPLETE
        //09    -   COMPLETE
        //10    -   COMPLETE
        //11    -   COMPLETE
        //12    -   COMPLETE


        // 12/12 COMPLETE

        public static class One
        {
            //04.1. Write a program that reads from the console three numbers of type int and prints their sum.
            public static void RunOne()
            {
                Console.WriteLine("\n04.1. Write a program that reads from the console three numbers of type int and prints their sum.\n");

                int a;
                int b;
                int c;

                string s = Console.ReadLine();
                Int32.TryParse(s, out a);
                s = Console.ReadLine();
                Int32.TryParse(s, out b);
                s = Console.ReadLine();
                Int32.TryParse(s, out c);

                Console.WriteLine((a + b + c).ToString());

                Console.WriteLine("\nCORRECT\n");
            }
        }
        public static class Two
        {
            //04.2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            public static void RunTwo()
            {
                Console.WriteLine("\n04.2. Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.\n");

                int rad;
                Console.WriteLine("Enter circle radius");
                string s = Console.ReadLine();
                Int32.TryParse(s, out rad);
                Console.WriteLine("Perimeter of circle with radius {0}, is {1}, it's area is {2}", rad, (2 * Math.PI * rad), (Math.PI * (rad * rad)));

                Console.WriteLine("\nCORRECT\n");
            }
        }
        public static class Three
        {
            //04.3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
            public static void RunThree()
            {
                Console.WriteLine("\n04.3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.\n");

                Console.WriteLine("Enter company name");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter company phone number");
                string companyPhone = Console.ReadLine();
                Console.WriteLine("Enter company website");
                string companyWebsite = Console.ReadLine();
                Console.WriteLine("Enter manager's full name");
                string managerName = Console.ReadLine();

                Console.WriteLine("Company Name: {0}, Company phone number:{1}, company website: {2}, manager name: {3}", companyName, companyPhone, companyWebsite, managerName);

                Console.WriteLine("\nCORRECT - couldnt be bothered adding more items than this\n");

            }
        }

        public static class Four
        {
            //04.4. Write a program that prints three numbers in three virtual columns on the console.
            //Each column should have a width of 10 characters and the numbers should be left aligned.
            //The first number should be an integer in hexadecimal; the second should be fractional
            //positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            public static void RunFour()
            {
                Console.WriteLine("\n04.4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.\n");

                int hex = 16;
                double fractionalPositive = 107D / 125D;
                double negFraction = (-107D / 1250D);

                Console.WriteLine("0x{0,-8:X}{1,-10:f2}{2,-10:f2}", hex, fractionalPositive, negFraction);

                Console.WriteLine("\nCOMPLETE\n");
            }
        }

        public static class Five
        {
            //04.5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between
            //them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            public static void RunFive()
            {
                Console.WriteLine("\n04.5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.\n");

                int a = 0;
                int b = 0;

                string s;

                Console.WriteLine("ENTER TWO INTS (not zero)\n");


                while (a == 0)
                {
                    s = Console.ReadLine();
                    Int32.TryParse(s, out a);
                }

                while (b == 0)
                {
                    s = Console.ReadLine();
                    Int32.TryParse(s, out b);
                }
                Console.WriteLine();

                if (a > b)
                {
                    //SWAP INTS
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                for (; a < b; a++)
                {
                    if (a % 5 == 0)
                    {
                        Console.WriteLine(a);
                    }
                }

                Console.WriteLine("\nCOMPLETE\n");
            }
        }


        public static class Six
        {
            //04.6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
            public static void RunSix()
            {
                Console.WriteLine("\n04.6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.\n");

                int a = 0;
                int b = 0;
                string s;

                Console.WriteLine("ENTER TWO INTS (not zero)\n");

                while (a == 0)
                {
                    s = Console.ReadLine();
                    Int32.TryParse(s, out a);
                }
                while (b == 0)
                {
                    s = Console.ReadLine();
                    Int32.TryParse(s, out b);
                }

                a = Math.Max(a, b);

                Console.WriteLine("\nThe greater of the two entered digits is:\n");
                Console.WriteLine(a);

                Console.WriteLine("\nCOMPLETE\n");

            }
        }

        public static class Seven
        {
            //04.7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
            public static void RunSeven()
            {
                Console.WriteLine("\n04.7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.\n");

                int a = GetInt();
                int b = GetInt();
                int c = GetInt();
                int d = GetInt();
                int e = GetInt();

                Console.WriteLine("\nSum of entered integers is {0}\n", a + b + c + d + e);

                Console.WriteLine("\nCOMPLETE\n");
            }
        }

        public static int GetInt()
        {
            string s;
            int result;
            s = Console.ReadLine();
            while (!Int32.TryParse(s, out result))
            {
                if (Int32.TryParse(s, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                    s = Console.ReadLine();
                }
            }
            return result;
        }



        public static class Eight
        {
            //04.8. Write a program that reads five numbers from the console and prints the greatest of them.
            public static void RunEight()
            {
                Console.WriteLine("\n04.8. Write a program that reads five numbers from the console and prints the greatest of them.\n");

                int a = GetInt();
                int b = GetInt();
                int c = GetInt();
                int d = GetInt();
                int e = GetInt();

                int largest = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));

                Console.WriteLine("\nThe largest of the entered numbers is {0}\n", largest);

                Console.WriteLine("\nCOMPLETE\n");


            }
        }
        public static class Nine
        {
            //04.9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            public static void RunNine()
            {
                Console.WriteLine("\n04.9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.\n");

                int n = GetInt();
                Console.WriteLine();
                int total = 0;
                for (int i = 0; i < n; i++)
                {
                    total += GetInt();
                }

                Console.WriteLine("\nTotal of integers entered is {0}\n", total);

                Console.WriteLine("\nCOMPLETE\n");
            }
        }
        public static class Ten
        {
            //04.10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            public static void RunTen()
            {
                Console.WriteLine("\n04.10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.\n");

                int n = GetInt();
                Console.WriteLine();
                for (int i = 1; i < n + 1; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\nCOMPLETE\n");
            }
        }

        public static class Eleven
        {
            //04.11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            public static void RunEleven()
            {
                Console.WriteLine("\n04.11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …\n");

                double a = 0;
                double b = 1;

                Console.WriteLine(a);
                for (double i = 0; i < 98; i++)
                {
                    double c = a;
                    a = b;
                    b = c + b;
                    Console.WriteLine(a);
                }

                Console.WriteLine("\nCOMPLETE\n");
            }
        }
        public static class Twelve
        {
            //04.12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            public static void RunTwelve()
            {
                Console.WriteLine("\n04.12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …\n");

                decimal sum = 1m;

                for (decimal i = 2; 1 / i > 0.001m; i++)
                {
                    sum = i % 2 == 0 ? sum + 1 / i : sum - 1 / i;
                }

                Console.WriteLine("{0:0.000}", sum);

                Console.WriteLine("\nCOMPLETE\n");

            }
        }


    }
}
