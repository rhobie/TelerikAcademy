using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap05_ConditionalStatements
    {
        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE 
        //04    -   COMPLETE
        //05    -   COMPLETE
        //06    -   INCOMPLETE
        //07    -   COMPLETE
        //08    -   COMPLETE
        //09    -   
        //10    -   COMPLETE
        //11    -   COMPLETE

        // 9/11 COMPLETE


        //1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
        //2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
        //3. Write a program that finds the biggest of three integers, using nested if statements.
        //4. Sort 3 real numbers in descending order. Use nested if statements.
        //5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
        //6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
        //7. Write a program that finds the greatest of given 5 numbers.
        //8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
        //9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
        //- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
        //- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
        //10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
        //- If the score is between 1 and 3, the program multiplies it by 10.
        //- If the score is between 4 and 6, the program multiplies it by 100.
        //- If the score is between 7 and 9, the program multiplies it by 1000.
        //- If the score is 0 or more than 9, the program prints an error message.
        //11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
        //- 0 --> "Zero"
        //- 12 --> "Twelve"
        //- 98 --> "Ninety eight"
        //- 273 --> "Two hundred seventy three"
        //- 400 --> "Four hundred"
        //- 501 --> "Five hundred and one"
        //- 711 --> "Seven hundred and eleven"


        public static class One
        {
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("05.1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.");
                Console.WriteLine();

                int x = 12;
                int y = 5;

                Console.WriteLine("BEFORE IF STATEMENT:");
                Console.WriteLine("x = {0}, y = {1}", x, y);

                if (x > y)
                {
                    x = x + y;
                    y = x - y;
                    x = x - y;
                }

                Console.WriteLine("AFTER IF STATEMENT:");
                Console.WriteLine("x = {0}, y = {1}", x, y);

                Console.WriteLine("CORRECT");
            }
        }
        public static class Two
        {
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("05.2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.");
                Console.WriteLine();

                int x = -1;
                int y = -2;
                int z = 0;

                int negNumCount = 0;

                if (x < 0)
                {
                    negNumCount++;
                }
                if (y < 0)
                {
                    negNumCount++;
                }
                if (z < 0)
                {
                    negNumCount++;
                }
                if (x == 0 || y == 0 || z == 0)
                {
                    Console.WriteLine("Product is zero");
                }
                else
                {
                    if (negNumCount % 2 == 0)
                    {
                        Console.WriteLine("Product is positive");
                    }
                    if (negNumCount % 2 != 0)
                    {
                        Console.WriteLine("Product is negative");
                    }
                }

                Console.WriteLine("CORRECT");
            }
        }
        public static class Three
        {
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("05.3. Write a program that finds the biggest of three integers, using nested if statements.");
                Console.WriteLine();

                int x = 45;
                int y = 23;
                int z = 12;

                if (x > y)
                {
                    if (x > z)
                    {
                        Console.WriteLine("x is the largest");
                    }
                    else
                    {
                        Console.WriteLine("z is the largest");
                    }
                }
                else if (y > z)
                {
                    Console.WriteLine("y is the largest");
                }
                else
                {
                    Console.WriteLine("z is the largest");
                }
                Console.WriteLine("CORRECT");
            }
        }
        public static class Four
        {
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("05.4. Sort 3 real numbers in descending order. Use nested if statements.");
                Console.WriteLine();

                int x = 340;
                int y = 12;
                int z = 650;

                if (x > y)
                {
                    if (x > z)
                    {
                        if (z > y)
                        {
                            Console.WriteLine("DESCENDING ORDER: X({0}), Z({1}), Y({2})", x, z, y);
                        }
                        else
                        {
                            Console.WriteLine("DESCENDING ORDER: X({0}), Y({1}), Z({2})", x, y, z);
                        }
                    }
                    else
                    {
                        Console.WriteLine("DESCENDING ORDER: Z({0}), X({1}), Y({2})", z, x, y);
                    }
                }
                if (x < y)
                {
                    if (x < z)
                    {
                        if (z < y)
                        {
                            Console.WriteLine("DESCENDING ORDER: Y({0}), Z({1}), X({2})", y, z, x);
                        }
                        else
                        {
                            Console.WriteLine("DESCENDING ORDER: Z({0}), Y({1}), X({2})", z, y, x);
                        }
                    }
                    else
                    {
                        Console.WriteLine("DESCENDING ORDER: Y({0}), X({1}), Z({2})", y, x, z);
                    }
                }
                Console.WriteLine("CORRECT");
            }
        }



        public static class Five
        {
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("05.5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.");
                Console.WriteLine();


                int num = 15;
                while (num > 9 || num < 0)
                {
                    Console.WriteLine("Please enter a digit between 0-9");
                    Int32.TryParse(Console.ReadLine(), out num);
                }

                switch (num)
                {
                    default:
                        break;
                    case 1:
                        Console.WriteLine("ONE");
                        break;
                    case 2:
                        Console.WriteLine("TWO");
                        break;
                    case 3:
                        Console.WriteLine("THREE");
                        break;
                    case 4:
                        Console.WriteLine("FOUR");
                        break;
                    case 5:
                        Console.WriteLine("FIVE");
                        break;
                    case 6:
                        Console.WriteLine("SIX");
                        break;
                    case 7:
                        Console.WriteLine("SEVEN");
                        break;
                    case 8:
                        Console.WriteLine("EIGHT");
                        break;
                    case 9:
                        Console.WriteLine("NINE");
                        break;
                }

                Console.WriteLine("CORRECT");
            }
        }

        public static class Six
        {
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("05.6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.");
                Console.WriteLine();

                int a = 4;
                int b = 3;
                int c = 6;

                int discriminant = b * b - (4 * a * c);

                if (discriminant == 0)
                {
                    //one double real root
                }
                else if (discriminant < 0)
                {
                    //no real roots
                }
                else //(discriminant > 0)
                {
                    //two real roots
                }

                Console.WriteLine("NOT FINSIHED");
            }
        }



        public static class Seven
        {
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("05.7. Write a program that finds the greatest of given 5 numbers.");
                Console.WriteLine();

                int x = 54;
                int y = 214;
                int z = 425;
                int a = 34;
                int b = 24;

                if (x > y && x > z && x > a && x > b)
                {
                    Console.WriteLine("Greatest int is X ({0})", x);
                }
                else if (y > x && y > z && y > a && y > b)
                {
                    Console.WriteLine("Greatest int is Y ({0})", y);
                }
                else if (z > x && z > y && z > a && z > b)
                {
                    Console.WriteLine("Greatest int is Z ({0})", z);
                }
                else if (a > x && a > y && a > z && a > b)
                {
                    Console.WriteLine("Greatest int is A ({0})", a);
                }
                else if (b > x && b > y && b > z && b > a)
                {
                    Console.WriteLine("Greatest int is B ({0})", b);
                }

                Console.WriteLine("CORRECT");
            }
        }
        public static class Eight
        {
            public static void RunEight()
            {
                Console.WriteLine("\n05.8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the");
                Console.WriteLine("variable is int or double, the program increases it by 1. If the variable is a string, the program appends \" * \" at the end.");
                Console.WriteLine("Print the result at the console. Use switch statement.\n");

                Console.WriteLine("Input an int (indicates what type the input is: 0 = int; 1 = double; 2 = string.");
                int type = CodeSnippets.GetInt();
                string result = "";

                switch (type)
                {
                    default:
                        Console.WriteLine("{0} is not a valid option", type);
                        break;
                    case 0:
                        type++;
                        result = type.ToString();
                        break;
                    case 1:
                        type++;
                        result = type.ToString();
                        break;
                    case 2:
                        result = type.ToString() + "*";
                        break;
                }

                Console.WriteLine(result);

                Console.WriteLine("\n...Not sure if this is what the question is asking for but...");

                Console.WriteLine("\nCOMPLETE\n");
            }
        }


        public static class Nine
        {
            //GUIDELINES:
            //Use nested if statements or series of 31 comparisons, in order to
            //check all the sums of the 31 subsets of the given numbers (without the
            //empty one). Note that the problem in general (with N numbers) is
            //complex and using loops will not be enough to solve it.

            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("05.9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:");
                Console.WriteLine(@"- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.");
                Console.WriteLine(@"- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.");
                Console.WriteLine();





                
























            }
        }
        public static class Ten
        {
            public static void RunTen()
            {
                Console.WriteLine("\n05.10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:");
                Console.WriteLine("- If the score is between 1 and 3, the program multiplies it by 10.");
                Console.WriteLine("- If the score is between 4 and 6, the program multiplies it by 100.");
                Console.WriteLine("- If the score is between 7 and 9, the program multiplies it by 1000.");
                Console.WriteLine("- If the score is 0 or more than 9, the program prints an error message.\n");

                int score = CodeSnippets.GetInt();
                int orgScore = score;
                if (score < 1 || score > 9)
                {
                    Console.WriteLine("ERROR!!");
                }
                else if (score == 1 || score == 2 || score == 3)
                {
                    score *= 10;
                }
                else if (score == 4 || score == 5 || score == 6)
                {
                    score *= 100;
                }
                else if (score == 7 || score == 8 || score == 9)
                {
                    score *= 1000;
                }

                Console.WriteLine("Score of {0} plus bonus points is {1}", orgScore, score);

                Console.WriteLine("\nCOMPLETE\n");
            }
        }
        public static class Eleven
        {
            public static void RunEleven()
            {
                Console.WriteLine("\n05.11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:");
                Console.WriteLine("- 0 --> \"Zero\"");
                Console.WriteLine("- 12 --> \"Twelve\"");
                Console.WriteLine("- 98 --> \"Ninety eight\"");
                Console.WriteLine("- 273 --> \"Two hundred seventy three\"");
                Console.WriteLine("- 400 --> \"Four hundred\"");
                Console.WriteLine("- 501 --> \"Five hundred and one\"");
                Console.WriteLine("- 711 --> \"Seven hundred and eleven\"\n");

                //could work this out better so that if hundreds place, ones are chosen followed by " hundred", rather than making each their own case. Would then be easier to add further numbers ie thousands.

                while (true)
                {
                    Console.WriteLine("Enter int bewteen 0 and 999");
                    int n = CodeSnippets.GetInt();
                    while (n < 0 || n > 999)
                    {
                        Console.WriteLine("Invalid int chosen");
                        n = CodeSnippets.GetInt();
                    }
                    string result = "";

                    StringBuilder sb = new StringBuilder();
                    switch (n)
                    {
                        default:
                            if (CodeSnippets.GetPlaceValue(n, 100) != 0) {
                                sb.Append(GetHundreds(n));
                            }
                            if (CodeSnippets.GetPlaceValue(n, 10) != 0) {
                                if (CodeSnippets.GetPlaceValue(n, 10) == 1) {
                                    sb.Append(GetTeens(n));
                                }
                                else {
                                    sb.Append(GetTens(n));
                                }
                            }
                            if (CodeSnippets.GetPlaceValue(n, 10) != 1)  {
                                sb.Append(GetOnes(n));
                            }
                            result = sb.ToString(); break;
                        case 0: result = "zero"; break;
                    }
                    Console.WriteLine(result.First().ToString().ToUpper() + result.Substring(1));

                    Console.WriteLine("\nCOMPLETE\n");
                }
            }
            public static string GetHundreds(int num)
            {
                string hundreds;
                switch (CodeSnippets.GetPlaceValue(num, 100))
                {
                    default: hundreds = ""; break;
                    case 1: hundreds = "one hundred"; break;
                    case 2: hundreds = "two hundred"; break;
                    case 3: hundreds = "three hundred"; break;
                    case 4: hundreds = "four hundred"; break;
                    case 5: hundreds = "five hundred"; break;
                    case 6: hundreds = "six hundred"; break;
                    case 7: hundreds = "seven hundred"; break;
                    case 8: hundreds = "eight hundred"; break;
                    case 9: hundreds = "nine hundred"; break;
                }
                if (CodeSnippets.GetPlaceValue(num, 10) != 0 || CodeSnippets.GetPlaceValue(num, 1) != 0)
                {
                    hundreds += " and ";
                }
                return hundreds;
            }

            public static string GetTens(int num)
            {
                string tens;
                switch (CodeSnippets.GetPlaceValue(num, 10))
                {
                    default: tens = ""; break;
                    case 0: tens = " and "; break;
                    case 1:
                        if (CodeSnippets.GetPlaceValue(num, 1) == 0) {
                            tens = "ten";
                        }
                        else  {
                            tens = GetTeens(CodeSnippets.GetPlaceValue(num, 1));
                        }
                        tens = "ten"; break;
                    case 2: tens = "twenty"; break;
                    case 3: tens = "thirty"; break;
                    case 4: tens = "forty"; break;
                    case 5: tens = "fifty"; break;
                    case 6: tens = "sixty"; break;
                    case 7: tens = "seventy"; break;
                    case 8: tens = "eighty"; break;
                    case 9: tens = "ninty"; break;
                }
                if (CodeSnippets.GetPlaceValue(num, 10) != 1 || CodeSnippets.GetPlaceValue(num, 1) != 0)
                {
                    tens += " ";
                }
                return tens;
            }
            public static string GetTeens(int num)
            {
                string teens;
                switch (CodeSnippets.GetPlaceValue(num, 1))
                {
                    default: teens = ""; break;
                    case 1: teens = "eleven"; break;
                    case 2: teens = "twelve"; break;
                    case 3: teens = "thirteen"; break;
                    case 4: teens = "fourteen"; break;
                    case 5: teens = "fifteen"; break;
                    case 6: teens = "sixteen"; break;
                    case 7: teens = "seventeen";  break;
                    case 8: teens = "eighteen"; break;
                    case 9: teens = "nineteen"; break;
                }
                return teens;
            }
            public static string GetOnes(int num)
            {
                string ones;
                switch (CodeSnippets.GetPlaceValue(num, 1))
                {
                    default: ones = "ERROR!!"; break;
                    case 0: ones = ""; break;
                    case 1: ones = "one"; break;
                    case 2: ones = "two"; break;
                    case 3: ones = "three"; break;
                    case 4: ones = "four"; break;
                    case 5: ones = "five"; break;
                    case 6: ones = "six"; break;
                    case 7: ones = "seven"; break;
                    case 8: ones = "eight"; break;
                    case 9: ones = "nine"; break;
                }
                return ones;
            }
        }
    }
}

