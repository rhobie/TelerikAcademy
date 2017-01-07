using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap03_OperatorsAndExpressions
    {
        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE
        //04    -   
        //05    -   COMPLETE
        //06    -   COMPLETE
        //07    -   COMPLETE
        //08    -   COMPLETE
        //09    -   COMPLETE
        //10    -   COMPLETE
        //11    -   
        //12    -   
        //13    -   
        //14    -   
        //15    -   
        //16    -   


        //6/16 COMPLETED


        public static class One
        {
            //03.1. Write an expression that checks whether an integer is odd or even.
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("03.1. Write an expression that checks whether an integer is odd or even.");
                Console.WriteLine();

                int a = 2;
                int b = 3;
                int c = 4;
                int d = 5;

                Console.WriteLine("int a ({0}) is:" + OddOrEven(a), a);
                Console.WriteLine("int b ({0}) is:" + OddOrEven(b), b);
                Console.WriteLine("int c ({0}) is:" + OddOrEven(c), c);
                Console.WriteLine("int d ({0}) is:" + OddOrEven(d), d);

                Console.WriteLine("CORRECT");
            }

            public static string OddOrEven(int num)
            {
                if (num % 2 == 0)
                {
                    return "EVEN";
                }
                else
                {
                    return "ODD";
                }
            }
        }
        public static class Two
        {
            //03.2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("03.2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.");
                Console.WriteLine();

                int a = 4;
                int b = 5;
                int c = 14;
                int d = 20;
                int e = 21;
                int f = 22;

                Console.WriteLine("int a ({0}) is divisble by 5 and 7: " + isDivs5and7(a), a);
                Console.WriteLine("int b ({0}) is divisble by 5 and 7: " + isDivs5and7(b), b);
                Console.WriteLine("int c ({0}) is divisble by 5 and 7: " + isDivs5and7(c), c);
                Console.WriteLine("int d ({0}) is divisble by 5 and 7: " + isDivs5and7(d), d);
                Console.WriteLine("int e ({0}) is divisble by 5 and 7: " + isDivs5and7(e), e);
                Console.WriteLine("int f ({0}) is divisble by 5 and 7: " + isDivs5and7(f), f);

                Console.WriteLine("CORRECT");
            }
            public static bool isDivs5and7(int num)
            {
                if (num % 5 == 0 || num % 7 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static class Three
        {
            //03.3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("03.3. Write an expression that looks for a given integer if its third digit (right to left) is 7.");
                Console.WriteLine();

                Console.WriteLine("Please enter an int, this program will check if the 3rd digit from the right is a 7");
                int n = GetIntFromConsole();

                if ((n / 100) % 10 == 7)
                {
                    Console.WriteLine("Third digit from the right is a seven");
                }
                else
                {
                    Console.WriteLine("Third digit from the right is NOT a seven");
                }


                Console.WriteLine("CORRECT");
            }
        }

        public static int GetIntFromConsole()
        {
            Console.WriteLine("Enter an int");
            Console.WriteLine();
            int entry;
            string s = Console.ReadLine();
            Int32.TryParse(s, out entry);
            Console.WriteLine();
            return entry;
        }
        public static class Four
        {
            //03.4. Write an expression that checks whether the third bit in a given integer is 1 or 0.
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("03.4. Write an expression that checks whether the third bit in a given integer is 1 or 0.");
                Console.WriteLine();

                //readline for int
                Console.WriteLine("enter int to check");
                int n = GetIntFromConsole();

                //NOT SURE HOW TO DO THIS


                //bitcheck

                //display results
            }
        }
        public static class Five
        {
            //03.5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("03.5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.");
                Console.WriteLine();

                Console.WriteLine("Enter side a");
                int a = GetIntFromConsole();
                Console.WriteLine("Enter side b");
                int b = GetIntFromConsole();
                Console.WriteLine("Enter height");
                int h = GetIntFromConsole();

                Console.WriteLine("Surface of trapezoid with given values is:{0}", ((a + b) * h / 2));

                Console.WriteLine("CORRECT");
            }
        }
        public static class Six
        {
            //03.6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("03.6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.");
                Console.WriteLine();

                Console.WriteLine("please enter width of rectangle");
                int a = GetIntFromConsole();
                Console.WriteLine("please enter height of rectangle");
                int b = GetIntFromConsole();

                Console.WriteLine("Area of rectangle is {0}. The perimeter of the rectangle is {1}", a * b, (a * 2) + (b * 2));

                Console.WriteLine("CORRECT");
            }
        }
        public static class Seven
        {
            //03.7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("03.7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.");
                Console.WriteLine();

                Console.WriteLine("Please enter your weight (on earth, whole numbers, and kg)");
                int earthWeight = GetIntFromConsole();

                Console.WriteLine("Your weight on the moon would be aprox {0}KG", earthWeight * 0.17);

                Console.WriteLine("CORRECT");
            }
        }
        public static class Eight
        {
            //03.8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine(@"03.8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.");
                Console.WriteLine();

                int x = GetIntFromConsole();
                int y = GetIntFromConsole();

                if ((x * x) + (y * y) <= (5 * 5))
                {
                    Console.WriteLine("The specified point is inside the circle");
                }
                else
                {
                    Console.WriteLine("The specified point is outside the circle");
                }

                Console.WriteLine("CORRECT");
            }
        }
        public static class Nine
        {
            //03.9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine(@"03.9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.");
                Console.WriteLine();


                int x = GetIntFromConsole();
                int y = GetIntFromConsole();


                if (((x * x) + (y * y) <= (5 * 5)) && ((x < -1 && x > 5)) && ((y < 1 && y > 5)))
                {
                    Console.WriteLine("Chosen point is outside of circle and rectangle");
                }
                else
                {
                    Console.WriteLine("Chosen point is inside circle and/or rectangle");


                    Console.WriteLine("CORRECT");
                }
            }
        }
        public static class Ten
        {
            //03.10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
            //- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //- Prints on the console the number in reversed order: dcba (in our example 1102).
            //- Puts the last digit in the first position: dabc (in our example 1201).
            //- Exchanges the second and the third digits: acbd (in our example 2101).
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("03.10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:");
                Console.WriteLine("- Calculates the sum of the digits (in our example 2+0+1+1 = 4).");
                Console.WriteLine("- Prints on the console the number in reversed order: dcba (in our example 1102).");
                Console.WriteLine("- Puts the last digit in the first position: dabc (in our example 1201).");
                Console.WriteLine("- Exchanges the second and the third digits: acbd (in our example 2101).");
                Console.WriteLine();

                int n = GetFourDigitIntFromConsole();

                int thousands = n / 1000 % 10;
                int hundreds = n / 100 % 10;
                int tens = n / 10 % 10;
                int ones = n % 10;

                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", thousands, hundreds, tens, ones, thousands + hundreds + tens + ones);

                Console.WriteLine("Your four digit int reversed is {3}{2}{1}{0}", thousands, hundreds, tens, ones);

                Console.WriteLine("last digit in first position is: {3}{0}{1}{2}", thousands, hundreds, tens, ones);

                Console.WriteLine("exchanging the 2nd and third digits gives: {0}{2}{1}{3}", thousands, hundreds, tens, ones);

                Console.WriteLine();
                Console.WriteLine("CORRECT");
                Console.WriteLine();
            }


            public static int GetFourDigitIntFromConsole()
            {
                Console.WriteLine("Enter a four digit int");
                Console.WriteLine();
                int entry = 0;
                while (entry < 1000 || entry > 9999)
                {
                    string s = Console.ReadLine();
                    Int32.TryParse(s, out entry);
                    if (entry < 1000 || entry > 9999)
                    {
                        Console.WriteLine("Please enter a four digit int");
                    }
                }
                Console.WriteLine();
                return entry;
            }
        }

        public static class Eleven
        {
            //03.11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("03.11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.");
                Console.WriteLine();

                Console.WriteLine("encoding test:");

                string msg = "This is my secret message.";
                string k = "7ecret..cyph3r//qu4y!"; // you can choose another key
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < msg.Length; i++)
                {
                    sb.Append((char)(msg[i] ^ k[i % k.Length]));
                }
                Console.WriteLine(sb.ToString());

            }
        }
        public static class Twelve
        {
            //03.12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("03.12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.");
                Console.WriteLine();
            }
        }
        public static class Thirteen
        {
            //03.13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("03.13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.");
                Console.WriteLine();
            }
        }
        public static class Fourteen
        {
            //03.14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
            public static void RunFourteen()
            {
                Console.WriteLine();
                Console.WriteLine("03.14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).");
                Console.WriteLine();
            }
        }
        public static class Fifteen
        {
            //03.15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
            public static void RunFifteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }
        public static class Sixteen
        {
            //03.16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
            public static void RunSixteen()
            {
                Console.WriteLine();
                Console.WriteLine("03.16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.");
                Console.WriteLine();
            }
        }
    }
}
