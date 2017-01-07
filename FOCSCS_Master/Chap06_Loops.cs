using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap06_Loops
    {
        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE
        //04    -   COMPLETE
        //05    -   COMPLETE
        //06    -   COMPLETE
        //07    -   
        //08    -   
        //09    -   
        //10    -   
        //11    -   
        //12    -   COMPLETE
        //13    -   COMPLETE
        //14    -   COMPLETE
        //15    -   COMPLETE
        //16    -   COMPLETE
        //17    -   COMPLETE
        //18    -   COMPLETE

        //13/18 COMPLETED


        public static class One
        {//06.1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("06.1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");
                Console.WriteLine();

                int entry = GetIntFromConsole();

                for (int i = 1; i < entry + 1; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("PASS");
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

        public static string GetStringFromConsole(string type)
        {
            Console.WriteLine("Enter {0}", type);
            Console.WriteLine();
            string s = Console.ReadLine();
            Console.WriteLine();
            return s;
        }

        public static class Two
        {//06.2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("06.2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");
                Console.WriteLine();

                int entry = GetIntFromConsole();

                for (int i = 1; i < entry + 1; i++)
                {
                    if (i % 7 != 0 && i % 3 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("PASS");
            }
        }
        public static class Three
        {//06.3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("06.3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.");
                Console.WriteLine();

                int a = GetIntFromConsole();
                int b = GetIntFromConsole();
                int c = GetIntFromConsole();
                int d = GetIntFromConsole();

                int[] arr = new int[4] { a, b, c, d };

                Console.WriteLine("Smallest number entered:{0}", arr.Min().ToString());
                Console.WriteLine("Largest number entered:{0}", arr.Max().ToString());

                Console.WriteLine("PASS");
            }
        }
        public static class Four
        {//06.4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("06.4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).");
                Console.WriteLine();

                string[] suit = new string[4] { "Hearts", "Diamonds", "Clubs", "Spades" };
                string[] value = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Console.WriteLine(value[j] + " of " + suit[i]);
                    }

                }
                Console.WriteLine("PASS");
                Console.ReadLine();

            }
        }
        public static class Five
        {//06.5. Write a program that reads from the console number N and print the sum
            //of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
            //13, 21, 34, 55, 89, 144, 233, 377, …
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("06.5. Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");
                Console.WriteLine();

                int entry = GetIntFromConsole();

                PrintFibSeq(entry);

                Console.WriteLine("PASS");
                Console.ReadLine();
            }
        }


        public static void PrintFibSeq(int count)
        {
            int fiba = 0;
            int fibb = 1;
            Console.WriteLine(fiba);
            Console.WriteLine(fibb);

            for (int i = 1; i < (count / 2); i++)
            {
                fiba = fiba + fibb;
                Console.WriteLine(fiba);
                fibb = fibb + fiba;
                Console.WriteLine(fibb);
            }
        }


        public static class Six
        {//06.6. Write a program that calculates N!/K! for given N and K (1<K<N).
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("06.6. Write a program that calculates N!/K! for given N and K (1<K<N).");
                Console.WriteLine();

                long n = GetIntFromConsole();
                long k = GetIntFromConsole();
                Console.WriteLine(GetBinCoeff(n, k));

                Console.WriteLine();
                Console.WriteLine("PASS");
                Console.ReadLine();
            }
        }
        public static long GetLongFromConsole()
        {
            Console.WriteLine("Enter an int");
            Console.WriteLine();
            long entry;
            string s = Console.ReadLine();
            long.TryParse(s, out entry);
            Console.WriteLine();
            return entry;
        }

        public static double GetBinCoeff(long n, long k)
        {
            double sum = 0;
            for (long i = 0; i < k; i++)
            {
                sum += Math.Log10(n - i);
                sum -= Math.Log10(i + 1);
            }
            return Math.Pow(10, sum);
        }

        public static class Seven
        {//06.7. Write a program that calculates N!*K!/(N-K)! for given N and K
            //(1<K<N).
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("/06.7. Write a program that calculates N!*K!/(N-K)! for given N and K");
                Console.WriteLine("(1<K<N)");
                Console.WriteLine();


            }


        }



        public static class Eight
        {//06.8. In combinatorics, the Catalan numbers are calculated by the following
            //REFER TO BOOK PG232
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("06.8. In combinatorics, the Catalan numbers are calculated by the following");
                Console.WriteLine("REFER TO BOOK PG232");
                Console.WriteLine();
            }
        }
        public static class Nine
        {//06.9. Write a program that for a given integers n and x, calculates the sum:
            //REFER TO BOOK PG232
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("06.9. Write a program that for a given integers n and x, calculates the sum:");
                Console.WriteLine("REFER TO BOOK PG232");
                Console.WriteLine();
            }
        }
        public static class Ten
        {//06.10. Write a program that reads from the console a positive integer number
            //N (N < 20) and prints a matrix of numbers as on the figures below:
            //REFER TO BOOK PG232
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("06.10. Write a program that reads from the console a positive integer number");
                Console.WriteLine("N (N < 20) and prints a matrix of numbers as on the figures below:");
                Console.WriteLine("REFER TO BOOK PG232");
                Console.WriteLine();
            }
        }
        public static class Eleven
        {//06.11. Write a program that calculates with how many zeroes the factorial of
            //a given number ends. Examples:
            //N = 10 -> N! = 3628800 -> 2
            //N = 20 -> N! = 2432902008176640000 -> 4
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("06.11. Write a program that calculates with how many zeroes the factorial of");
                Console.WriteLine("a given number ends. Examples:");
                Console.WriteLine("N = 10 -> N! = 3628800 -> 2");
                Console.WriteLine("N = 20 -> N! = 2432902008176640000 -> 4");
                Console.WriteLine();
            }
        }
        public static class Twelve
        {//06.12. Write a program that converts a given number from decimal to binary
            //notation (numeral system).
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("06.12. Write a program that converts a given number from decimal to binary notation (numeral system).");
                Console.WriteLine();

                decimal num = GetIntFromConsole();

                string inBinary = ConvertToBinary(num);

                Console.WriteLine("{0} in binary is {1}", num, inBinary);

                Console.WriteLine("PASS");
            }

            public static string ConvertToBinary(decimal i)
            {
                string strNum = Convert.ToString((int)i, 2);

                return strNum;
            }
        }
        public static class Thirteen
        {//06.13. Write a program that converts a given number from binary to decimal
            //notation.
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("06.13. Write a program that converts a given number from binary to decimal notation.");
                Console.WriteLine();

                string binary = GetStringFromConsole("binary");

                decimal decNum = ConvertFromBinary(binary);

                Console.WriteLine("The binary {0} as a decimal is {1}", binary, decNum);

                Console.WriteLine("PASS");
            }

            public static decimal ConvertFromBinary(string binaryString)
            {
                int num = Convert.ToInt32(binaryString, 2);
                return (decimal)num;
            }

        }

        public static class Fourteen
        {//06.14. Write a program that converts a given number from decimal to
            //hexadecimal notation.
            public static void RunFourteen()
            {
                Console.WriteLine();
                Console.WriteLine("06.14. Write a program that converts a given number from decimal to hexadecimal notation.");
                Console.WriteLine();


                decimal num = GetIntFromConsole();

                string inHex = ConvertToHex(num);

                Console.WriteLine("{0} in hex is {1}", num, inHex);

                Console.WriteLine("PASS");
            }

            public static string ConvertToHex(decimal i)
            {
                int num = (int)i;

                string strNum = num.ToString("X");

                return strNum;
            }


        }
        public static class Fifteen
        {//06.15. Write a program that converts a given number from hexadecimal to
            //decimal notation.
            public static void RunFifteen()
            {
                Console.WriteLine();
                Console.WriteLine("06.15. Write a program that converts a given number from hexadecimal to decimal notation.");
                Console.WriteLine();

                string hex = GetStringFromConsole("hex");

                int fromHex = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                decimal deNum = (decimal)fromHex;

                Console.WriteLine("The hex {0} as a decimal is {1}", hex, fromHex);

                Console.WriteLine("PASS");
            }
        }
        static Random rand = new Random();
        public static class Sixteen
        {//06.16. Write a program that by a given integer N prints the numbers from 1 to N
            //in random order.
            public static void RunSixteen()
            {
                Console.WriteLine();
                Console.WriteLine("06.16. Write a program that by a given integer N prints the numbers from 1 to N in random order.");
                Console.WriteLine();

                int num = GetIntFromConsole();

                List<int> intList = new List<int>();

                for (int i = 1; i < num + 1; i++)
                {
                    intList.Add(i);
                }
                for (int i = 1; i < num + 1; i++)
                {
                    int randomElement = rand.Next(0, intList.Count);
                    Console.WriteLine(intList[randomElement]);
                    intList.RemoveAt(randomElement);
                }

                Console.WriteLine("PASS");
            }
        }

        public static class Seventeen
        {//06.17. Write a program that given two numbers finds their greatest common
            //divisor (GCD) and their least common multiple (LCM). You may use
            //the formula LCM(a, b) = |a*b| / GCD(a, b).
            public static void RunSeventeen()
            {
                Console.WriteLine();
                Console.WriteLine("06.17. Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use");
                Console.WriteLine("the formula LCM(a, b) = |a*b| / GCD(a, b).");
                Console.WriteLine();

                int a = GetIntFromConsole();
                int b = GetIntFromConsole();

                int gcd = GCD(a, b);
                int lcm = LCM(a, b);

                Console.WriteLine("GCD of {0} and {1} is {2}", a, b, gcd);
                Console.WriteLine("LCM of {0} and {1} is {2}", a, b, lcm);

                Console.WriteLine("PASS");

            }
            //FOUND AND ADAPTED THE FOLLOWING TWO METHODS ON STACKOVERFLOW:
            //(GUIDELINES SAID THIS IS FINE)
            static int GCD(int a, int b)
            {
                return b == 0 ? a : GCD(b, a % b);
            }
            static int LCM(int a, int b)
            {
                return (a / GCD(a, b)) * b;
            }
            //-----------------------------------------------------------
        }
        public static class Eightteen
        {//06.18. * Write a program that for a given number n, outputs a matrix in the form of a spiral:
            //Example for n=4:
            //REFER TO BOOK PG233
            public static void RunEightteen()
            {
                Console.WriteLine();
                Console.WriteLine("06.18. * Write a program that for a given number n, outputs a matrix in the form of a spiral:");
                Console.WriteLine("Example for n=4:");
                Console.WriteLine();
                Console.WriteLine(" 1 |  2 |  3 | 4 ");
                Console.WriteLine("----------------");
                Console.WriteLine("12 | 13 | 14 | 5 ");
                Console.WriteLine("----------------");
                Console.WriteLine("11 | 16 | 15 | 6 ");
                Console.WriteLine("----------------");
                Console.WriteLine("10 |  9 |  8 | 7 ");

                Console.WriteLine();
                

                int n = GetIntFromConsole();

                int[,] matrix = new int[n, n];

                FillMatrix(matrix, n);
                PrintMatrix(matrix, n);

                Console.WriteLine("PASS");
            }

            private static void FillMatrix(int[,] matrix, int n)
            {
                int posX = 0; //start top left
                int posY = 0; //start top left

                int stepCount = n-1; // Perform x step(s) in the current direction
                int stepPosition = 0; // 0 steps already performed
                int stepChange = -1;// Steps count will change after 2 steps
                int direction = 0;
                int count = n * n;

                for (int i = 0; i < count; i++)
                {
                    matrix[posX, posY] = i+1;

                    if (stepPosition < stepCount)
                    {
                        stepPosition++;
                    }
                    else
                    {
                        stepPosition = 1;
                        if ((stepChange == 1))
                        {
                            stepCount--;
                        }
                        stepChange = (stepChange + 1) % 2;
                        direction = (direction + 1) % 4;
                    }

                    // Move to the next cell in the current direction
                    switch (direction)
                    {
                        case 0: 
                            posY++;//right
                            break;
                        case 1: 
                            posX++;//down
                            break;
                        case 2: 
                            posY--;//left
                            break;
                        case 3: 
                            posX--;//up
                            break;
                    }
                }
            }

            private static void PrintMatrix(int[,] matrix, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,3}", matrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
