using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap11_CreatingAndUsingObjects
    {
        //1. Write a program, which reads from the console a year and checks if it is a leap year.
        //2. Write a program, which generates and prints on the console 10 random numbers in the range [100, 200].
        //3. Write a program, which prints, on the console which day of the week is today.
        //4. Write a program, which prints on the standard output the count of days, hours, and minutes, which have passes since the computer is started until the moment of the program execution. For the implementation use the class Environment.
        //5. Write a program which by given two sides finds the hypotenuse of a right triangle. Implement entering of the lengths of the sides from the
        //standard input, and for the calculation of the hypotenuse use methods of the class Math.
        //6. Write a program which calculates the area of a triangle with the following given:
        //- three sides;
        //- side and the altitude to it;
        //- two sides and the angle between them in degrees.
        //7. Define your own namespace CreatingAndUsingObjects and place in it two classes Cat and Sequence, which we used in the examples of the current chapter. Define one more namespace and make a class, which calls the classes Cat and Sequence, in it.
        //8. Write a program which creates 10 objects of type Cat, gives them names CatN, where N is a unique serial number of the object, and in the end call the method SayMiau() for each of them. For the implementation use the namespace CreatingAndUsingObjects.
        //9. Write a program, which calculates the count of workdays between the current date and another given date after the current (inclusive). Consider that workdays are all days from Monday to Friday, which are not public holidays, except when Saturday is a working day. The program should keep a list of predefined public holidays, as well as a list of predefined working Saturdays.
        //10. You are given a sequence of positive integer numbers given as string of numbers separated by a space. Write a program, which calculates their sum. Example: "43 68 9 23 318"  461.
        //11. Write a program, which generates a random advertising message for some product. The message has to consist of laudatory phrase, followed by a laudatory story, followed by author (first and last name) and city, which are selected from predefined lists. For example, let’s have the following lists:
        //- Laudatory phrases: {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."}.
        //- Laudatory stories: {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."}.
        //- First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}.
        //- Last name of the author: {"Johnson", "Peterson", "Charls"}.
        //- Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}.
        //Then the program would print randomly generated advertising message like the following:
        //I use this product constantly. You should try it, too. I am very satisfied. -- Hellen Peterson, Berlin
        //12. * Write a program, which calculates the value of a given numeral expression given as a string. The numeral expression consists of:
        //- real numbers, for example 5, 18.33, 3.14159, 12.6;
        //- arithmetic operations: +, -, *, / (with their standard priorities);
        //- mathematical functions: ln(x), sqrt(x), pow(x, y);
        //- brackets for changing the priorities of the operations: ( and ).
        //Note that the numeral expressions have priorities, for example the expression -1 + 2 + 3 * 4 - 0.5 = (-1) + 2 + (3 * 4) - 0.5 = 12.5.

        public static class One
        {
            public static void RunOne()
            {
                //EXERCISE1:
                //1. Write a program, which reads from the console a year and checks if it is a leap year.
                int userYear = PromptYear();
                if (LeapYears.CheckLeapYear(userYear) == false)
                {
                    Console.WriteLine("{0} is not a leap year", userYear);
                }
                else
                {
                    Console.WriteLine("{0} is a leap year", userYear);
                }


                Console.WriteLine("CORRECT");
            }

            public static int PromptYear()
            {
                Console.WriteLine("Please enter a year, and I will tell you if it is a leap year");
                int qYear = int.Parse(Console.ReadLine());

                return qYear;
            }

            class LeapYears
            {
                public static bool CheckLeapYear(int year)
                {
                    if (CheckLeapYearRule1(year) == true && CheckLeapYearRule2(year) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


                private static bool CheckLeapYearRule1(int year)
                {
                    bool isLeap;
                    if (year % 4 == 0)
                    {
                        isLeap = true;
                    }
                    else
                    {
                        isLeap = false;
                    }
                    return isLeap;
                }

                private static bool CheckLeapYearRule2(int year)
                {
                    bool isLeap;
                    if (year % 400 == 0 && year / 100 % 2 == 0)
                    {
                        isLeap = true;
                    }
                    else
                    {
                        isLeap = false;
                    }
                    return isLeap;
                }
            }
        }
        public static class Two
        {
            public static void RunTwo()
            {
                //EXERCISE2:
                //2. Write a program, which generates and prints on the console 10 random numbers in the range [100, 200].
                for (int i = 0; i < 10; i++)
                {
                    int oldRan;
                    int newRan;
                    do
                    {
                        oldRan = rand.RandNumTo100();
                        newRan = rand.RandNumTo100();
                    } while (oldRan == newRan);
                    Console.WriteLine(newRan);
                }

                Console.WriteLine("CORRECT");
            }

            class rand
            {
                public static int RandNumTo100()
                {
                    Random random = new Random();
                    int randNum = random.Next(100, 201);

                    return randNum;

                }


            }
        }
        public static class Three
        {
            public static void RunThree()
            {

                //EXERCISE3:
                //3. Write a program, which prints, on the console which day of the week is today.
                DateTime thisDay = DateTime.Today;
                Console.WriteLine(thisDay.DayOfWeek);

                Console.WriteLine("CORRECT");
            }
        }
        public static class Four
        {
            public static void RunFour()
            {
                //EXERCISE4:
                //Write a program, which prints on the standard output the count of days, hours, and minutes,
                //which have passes since the computer is started until the moment of the program execution.
                //For the implementation use the class Environment.
                int upTime = System.Environment.TickCount;
                upTime = upTime / 1000;
                TimeSpan t = TimeSpan.FromSeconds(upTime);
                string answer = string.Format("{4:D1} days:{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                t.Hours,
                                t.Minutes,
                                t.Seconds,
                                t.Milliseconds,
                                t.Days);
                Console.WriteLine(answer);


                Console.WriteLine("CORRECT");
            }
        }
        public static class Five
        {
            public static void RunFive()
            {
                //EXERCISE5:
                //Write a program which by given two sides finds the hypotenuse of a right triangle. Implement entering of the lengths of the sides from the
                //standard input, and for the calculation of the hypotenuse use methods of the class Math.
                Console.WriteLine("Please enter side a of the right-angled triangle, followed by enter and then side b, followed by enter");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                //double c = Math.Sqrt(((a*a)+(b*b))); //Less Math Class
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine("Side a is {0} length units, side b is {1} length units", a, b);
                Console.WriteLine("Which makes side c equal {0} length units", c);

                Console.WriteLine("CORRECT");
            }
        }
        public static class Six
        {
            public static void RunSix()
            {

                //EXERCISE6: NOT FINSHED
                //Write a program which calculates the area of a triangle with the following given:
                //- three sides;
                //- side and the altitude to it;
                //- two sides and the angle between them in degrees.

                Console.WriteLine("Please enter one of the following to calculate the area of the triangle:");
                Console.WriteLine("-Three sides as ints");
                Console.WriteLine("-One side as an int and the height of the triangle");
                Console.WriteLine("-Two sides as ints and the angle between them as a double");

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                double answer = TriangleCalc.TriangleArea(a, b, c);
                Console.WriteLine(answer);
            }


            class TriangleCalc
            {
                //- three sides;
                //public static void TriangleArea(int sideA, int sideB, int sideC)
                //{

                //}

                ////- side and the altitude to it;
                //public static void TriangleArea(int side, double altitude)
                //{

                //}

                //- two sides and the angle between them in degrees.
                public static double TriangleArea(int sideA, int sideB, double angle)
                {
                    double answer = sideA * sideB * ((Math.Sin(angle)) / 2);
                    return answer;
                }


            }
        }
    }
}









