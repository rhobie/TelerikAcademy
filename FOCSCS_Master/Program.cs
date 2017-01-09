using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{

    //  | (• ◡•)| (❍ᴥ❍ʋ)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = Console.WindowWidth * 2;

            //Chap01.RunChap01(); //Intoroduction To Programming              //COMPLETE    14/14 - need to get decompiler and change ex14
            //Chap02.RunChap02(); //Primitive Types and Variables             //COMPLETE    13/13
            //Chap03.RunChap03(); //OperatorsAndExpressions                   //INCOMPLETE  12/16 - rest is bit operaters/shifting etc, will come back to this
            //Chap04.RunChap04(); //Console Input and Output                  //COMPLETE    12/12  
            //Chap05.RunChap05(); //Conditional Statements                    //INCOMPLETE  9/11 -started
            //Chap06.RunChap06(); //Loops                                     //INCOMPLETE  13/18 - coefficents etc :s
            Chap07.RunChap07(); //Arrays                                    //INCOMPLETE  5/25 -started (one incomplete solution (#5))
            //Chap08.RunChap08(); //Numeral Systems                           //INCOMPLETE  0/15 -not started
            //Chap09.RunChap09(); //Methods                                   //INCOMPLETE  7/13 -started (one incorrect (#8))
            //Chap10.RunChap10(); //Recursion                                 //INCOMPLETE  0/14 -not started
            //Chap11.RunChap11(); //Creating and Using Objects                //INCOMPLETE  5/12 -started -needs fixing
            //Chap12.RunChap12(); //Exception Handling                        //INCOMPLETE  0/13 -not started
            //Chap13.RunChap13(); //Strings And Text Processing               //INCOMPLETE  0/26 -not started
            //Chap14.RunChap14(); //Defining Classes                          //INCOMPLETE  ?/?  -started
            //Chap14.RunChap15(); //Text Files                                //INCOMPLETE  4/13 -started
            //Chap16.RunChap16(); //Linear Data Structures                    //INCOMPLETE  11ish/18

            //Chap17.RunChap17(); //Trees And Graphs                          //NOT UP TO YET
            //Chap18.RunChap18(); //Dictionaries, Hash-tables and Sets        //NOT UP TO YET
            //Chap19.RunChap19(); //Data Structures and Algorithm Complexity  //NOT UP TO YET
            //Chap20.RunChap20(); //OOP Principles                            //NOT UP TO YET
            //Chap21.RunChap21(); //High-Quality Programming Code             //NOT UP TO YET
            //Chap22.RunChap22(); //Lambda Expressions and LINQ               //NOT UP TO YET
            //Chap23.RunChap23(); //Methodology of Problem Solving            //NOT UP TO YET
            //Chap24.RunChap24(); //Sample Programming Exam-Topic1            //NOT UP TO YET
            //Chap25.RunChap25(); //Sample Programming Exam-Topic2            //NOT UP TO YET
            //Chap26.RunChap26(); //Sample Programming Exam-Topic3            //NOT UP TO YET

            Console.ReadLine();
        }
    }


    public static class Chap01 //Intoroduction To Programming
    {
        public static void RunChap01()
        {
            //1. Install and make yourself familiar with Microsoft Visual Studio and Microsoft Developer Network (MSDN) Library Documentation.  //COMPLETE
            Chap01_IntroductionToProgramming.One.RunOne();
            //2. Find the description of the System.Console class in the standard .NET API documentation (MSDN Library).                        //COMPLETE
            Chap01_IntroductionToProgramming.Two.RunTwo();
            //3. Find the description of the System.Console.WriteLine() method and its different possible parameters in the MSDN Library.       //COMPLETE
            Chap01_IntroductionToProgramming.Three.RunThree();
            //4. Compile and execute the sample program from this chapter using the command prompt (the console) and Visual Studio.             //COMPLETE
            Chap01_IntroductionToProgramming.Four.RunFour();
            //5. Modify the sample program to print a different greeting, for example "Good Day!".                                              //COMPLETE
            Chap01_IntroductionToProgramming.Five.RunFive();
            //6. Write a console application that prints your first and last name on the console.                                               //COMPLETE
            Chap01_IntroductionToProgramming.Six.RunSix();
            //7. Write a program that prints the following numbers on the console 1, 101, 1001, each on a new line.                             //COMPLETE
            Chap01_IntroductionToProgramming.Seven.RunSEven();
            //8. Write a program that prints on the console the current date and time.                                                          //COMPLETE
            Chap01_IntroductionToProgramming.Eight.RunEight();
            //9. Write a program that prints the square root of 12345.                                                                          //COMPLETE
            Chap01_IntroductionToProgramming.Nine.RunNine();
            //10. Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.                                     //COMPLETE
            Chap01_IntroductionToProgramming.Ten.RunTen();
            //11. Write a program that reads your age from the console and prints your age after 10 year                                        //COMPLETE
            Chap01_IntroductionToProgramming.Eleven.RunEleven();
            //12. Describe the difference between C# and the .NET Framework.                                                                    //COMPLETE
            Chap01_IntroductionToProgramming.Twelve.RunTwelve();
            //13. Make a list of the most popular programming languages. How are they different from C#?                                        //COMPLETE
            Chap01_IntroductionToProgramming.Thirteen.RunThirteen();
            //14. Decompile the example program from exercise 5.                                                                                //COMPLETE ISH
            Chap01_IntroductionToProgramming.Fourteen.RunFourteen();

            Console.WriteLine("CHAPTER 1 COMPLETED 14/14");
        }
    }

    public static class Chap02 //Primitive Types and Variables
    {
        public static void RunChap02()
        {
            //1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
            Chap02_PrimitiveTypesAndVariables.One.RunOne();
            //2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
            Chap02_PrimitiveTypesAndVariables.Two.RunTwo();
            //3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
            Chap02_PrimitiveTypesAndVariables.Three.RunThree();
            //4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
            Chap02_PrimitiveTypesAndVariables.Four.RunFour();
            //5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
            Chap02_PrimitiveTypesAndVariables.Five.RunFive();
            //6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
            Chap02_PrimitiveTypesAndVariables.Six.RunSix();
            //7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
            Chap02_PrimitiveTypesAndVariables.Seven.RunSeven();
            //8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
            Chap02_PrimitiveTypesAndVariables.Eight.RunEight();
            //9. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
            Chap02_PrimitiveTypesAndVariables.Nine.RunNine();
            //10. Write a program to print a figure in the shape of a heart by the sign "o".
            Chap02_PrimitiveTypesAndVariables.Ten.RunTen();
            //11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
            Chap02_PrimitiveTypesAndVariables.Eleven.RunEleven();
            //12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
            Chap02_PrimitiveTypesAndVariables.Twelve.RunTwelve();
            //13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
            Chap02_PrimitiveTypesAndVariables.Thirteen.RunThirteen();

            Console.WriteLine("CHAPTER 2 COMPLETED 13/13");
        }
    }

    public static class Chap03 //Operators And Expressions
    {
        public static void RunChap03()
        {

            ////1. Write an expression that checks whether an integer is odd or even.
            //Chap03_OperatorsAndExpressions.One.RunOne(); //COMPLETE
            ////2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            //Chap03_OperatorsAndExpressions.Two.RunTwo(); //COMPLETE
            ////3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
            //Chap03_OperatorsAndExpressions.Three.RunThree(); //COMPLETE
            ////4. Write an expression that checks whether the third bit in a given integer is 1 or 0.
            //Chap03_OperatorsAndExpressions.Four.RunFour(); //COMPLETE
            ////5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            //Chap03_OperatorsAndExpressions.Five.RunFive(); //COMPLETE
            ////6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            //Chap03_OperatorsAndExpressions.Six.RunSix(); //COMPLETE
            ////7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
            //Chap03_OperatorsAndExpressions.Seven.RunSeven(); //COMPLETE
            ////8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
            //Chap03_OperatorsAndExpressions.Eight.RunEight(); //COMPLETE
            ////9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
            //Chap03_OperatorsAndExpressions.Nine.RunNine(); //COMPLETE
            ////10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
            //    //- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //    //- Prints on the console the number in reversed order: dcba (in our example 1102).
            //    //- Puts the last digit in the first position: dabc (in our example 1201).
            //    //- Exchanges the second and the third digits: acbd (in our example 2101).
            //Chap03_OperatorsAndExpressions.Ten.RunTen(); //COMPLETE
            ////11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
            //Chap03_OperatorsAndExpressions.Eleven.RunEleven(); //COMPLETE
            ////12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
            //Chap03_OperatorsAndExpressions.Twelve.RunTwelve(); //COMPLETE
            ////13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
            Chap03_OperatorsAndExpressions.Thirteen.RunThirteen();
            ////14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
            //Chap03_OperatorsAndExpressions.Fourteen.RunFourteen();
            ////15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
            //Chap03_OperatorsAndExpressions.Fifteen.RunFifteen();
            ////16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
            //Chap03_OperatorsAndExpressions.Sixteen.RunSixteen();

            Console.WriteLine("CHAPTER 3 INCOMPLETE 12/16");
        }
    }

    public static class Chap04 //Console Input and Output
    {
        public static void RunChap04()
        {
            //1. Write a program that reads from the console three numbers of type int and prints their sum.
            Chap04_ConsoleInputAndOutput.One.RunOne(); //COMPLETE
            //2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            Chap04_ConsoleInputAndOutput.Two.RunTwo(); //COMPLETE
            //3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
            Chap04_ConsoleInputAndOutput.Three.RunThree(); //COMPLETE
            //4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            Chap04_ConsoleInputAndOutput.Four.RunFour(); //COMPLETE
            //5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            Chap04_ConsoleInputAndOutput.Five.RunFive(); //COMPLETE
            //6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
            Chap04_ConsoleInputAndOutput.Six.RunSix(); //COMPLETE
            //7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
            Chap04_ConsoleInputAndOutput.Seven.RunSeven(); //COMPLETE
            //8. Write a program that reads five numbers from the console and prints the greatest of them.
            Chap04_ConsoleInputAndOutput.Eight.RunEight(); //COMPLETE
            //9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            Chap04_ConsoleInputAndOutput.Nine.RunNine(); //COMPLETE
            //10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            Chap04_ConsoleInputAndOutput.Ten.RunTen(); //COMPLETE
            //11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            Chap04_ConsoleInputAndOutput.Eleven.RunEleven(); //COMPLETE
            //12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            Chap04_ConsoleInputAndOutput.Twelve.RunTwelve(); //COMPLETE

            Console.WriteLine("CHAPTER 4 COMPLETED 12/12");
        }

    }

    public static class Chap05 //ConditionalStatements
    {
        public static void RunChap05()
        {

            ////1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
            //Chap05_ConditionalStatements.One.RunOne(); //COMPLETE
            ////2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
            //Chap05_ConditionalStatements.Two.RunTwo(); //COMPELTE
            ////3. Write a program that finds the biggest of three integers, using nested if statements.
            //Chap05_ConditionalStatements.Three.RunThree(); //COMPLETE
            ////4. Sort 3 real numbers in descending order. Use nested if statements.
            //Chap05_ConditionalStatements.Four.RunFour(); //COMPLETE
            ////5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
            //Chap05_ConditionalStatements.Five.RunFive(); //COMPLETE
            ////6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
            //Chap05_ConditionalStatements.Six.RunSix(); //INCOMPLETE!!! (co-efficents)
            ////7. Write a program that finds the greatest of given 5 numbers.
            //Chap05_ConditionalStatements.Seven.RunSeven(); //CORRECT
            ////8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
            //Chap05_ConditionalStatements.Eight.RunEight(); //CORRECT (i think, not sure I understand the question correctly)
            ////9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
            ////- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
            ////- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
            //Chap05_ConditionalStatements.Nine.RunNine(); // HAVE NOT STARTED
            ////10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
            ////- If the score is between 1 and 3, the program multiplies it by 10.
            ////- If the score is between 4 and 6, the program multiplies it by 100.
            ////- If the score is between 7 and 9, the program multiplies it by 1000.
            ////- If the score is 0 or more than 9, the program prints an error message.
            //Chap05_ConditionalStatements.Ten.RunTen(); //COMPLETE
            ////11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
            ////- 0 --> "Zero"
            ////- 12 --> "Twelve"
            ////- 98 --> "Ninety eight"
            ////- 273 --> "Two hundred seventy three"
            ////- 400 --> "Four hundred"
            ////- 501 --> "Five hundred and one"
            ////- 711 --> "Seven hundred and eleven"
            //Chap05_ConditionalStatements.Eleven.RunEleven(); //CORRECT

            Console.WriteLine("CHAPTER 5 INCOMPLETE 9/11, (#6 && #9 incomplete)");
        }

    }

    public static class Chap06 //Loops
    {
        public static void RunChap06()
        {

            ////1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            //Chap06_Loops.One.RunOne(); //COMPLETE
            ////2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
            //Chap06_Loops.Two.RunTwo(); //COMPLETE
            ////3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.
            //Chap06_Loops.Three.RunThree(); //COMPLETE
            ////4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
            //Chap06_Loops.Four.RunFour(); //COMPLETE
            ////5. Write a program that reads from the console number N and print the sum
            ////of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
            ////13, 21, 34, 55, 89, 144, 233, 377, …
            //Chap06_Loops.Five.RunFive(); //COMPLETE...ish - could fix so that it preints the correct amount of numbers though....
            ////6. Write a program that calculates N!/K! for given N and K (1<K<N).
            //Chap06_Loops.Six.RunSix(); //COMPLETE - maybe not, don't know anything about binomial coefficients (stole the calculation method from stackoverflow)
            ////7. Write a program that calculates N!*K!/(N-K)! for given N and K
            ////(1<K<N).
            //Chap06_Loops.Seven.RunSeven();
            ////8. In combinatorics, the Catalan numbers are calculated by the following
            ////REFER TO BOOK PG232
            //Chap06_Loops.Eight.RunEight();
            ////9. Write a program that for a given integers n and x, calculates the sum:
            ////REFER TO BOOK PG232
            //Chap06_Loops.Nine.RunNine();
            ////10. Write a program that reads from the console a positive integer number
            ////N (N < 20) and prints a matrix of numbers as on the figures below:
            ////REFER TO BOOK PG232
            //Chap06_Loops.Ten.RunTen();
            ////11. Write a program that calculates with how many zeroes the factorial of
            ////a given number ends. Examples:
            ////N = 10 -> N! = 3628800 -> 2
            ////N = 20 -> N! = 2432902008176640000 -> 4
            //Chap06_Loops.Eleven.RunEleven();
            ////12. Write a program that converts a given number from decimal to binary
            ////notation (numeral system).
            //Chap06_Loops.Twelve.RunTwelve(); //COMPLETE
            ////13. Write a program that converts a given number from binary to decimal
            ////notation.
            //Chap06_Loops.Thirteen.RunThirteen(); //COMPLETE
            ////14. Write a program that converts a given number from decimal to
            ////hexadecimal notation.
            //Chap06_Loops.Fourteen.RunFourteen(); //COMPLETE
            ////15. Write a program that converts a given number from hexadecimal to
            ////decimal notation.
            //Chap06_Loops.Fifteen.RunFifteen(); //COMPLETE
            ////16. Write a program that by a given integer N prints the numbers from 1 to N
            ////in random order.
            //Chap06_Loops.Sixteen.RunSixteen(); //COMPLETE
            ////17. Write a program that given two numbers finds their greatest common
            ////divisor (GCD) and their least common multiple (LCM). You may use
            ////the formula LCM(a, b) = |a*b| / GCD(a, b).
            //Chap06_Loops.Seventeen.RunSeventeen(); //COMPLETE
            ////18. * Write a program that for a given number n, outputs a matrix in the form of a spiral:
            ////Example for n=4:
            ////REFER TO BOOK PG233
            //Chap06_Loops.Eightteen.RunEightteen(); //COMPLETE
        }

    }


    public static class Chap07 //Arrays
    {
        public static void RunChap07()
        {
            ////1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.
            //Chap07_Arrays.One.RunOne(); //COMPLETE
            
            ////2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).
            //Chap07_Arrays.Two.RunTwo(); //COMPLETE
            
            ////3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.
            //Chap07_Arrays.Three.RunThree(); //COMPLETE
            
            ////4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.
            //Chap07_Arrays.Four.RunFour(); //COMPLETE
            
            ////5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
            //Chap07_Arrays.Five.RunFive(); //HALF COMPLETE, needs adjusting
            
            ////6. Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}.
            //Chap07_Arrays.Six.RunSix();
            
            ////7. Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.
            //Chap07_Arrays.Seven.RunSeven();
            
            ////8. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm "selection sort".
            Chap07_Arrays.Eight.RunEight();
            
            ////9. Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11
            //Chap07_Arrays.Nine.RunNine();
            
            ////10. Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).
            //Chap07_Arrays.Ten.RunTen();
            
            ////11. Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}.
            //Chap07_Arrays.Eleven.RunEleven();
            
            ////12. Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion:
            ////REFER BOOK FOR GRIDS
            //Chap07_Arrays.Twelve.RunTwelve();
            
            ////13. Write a program, which creates a rectangular array with size of n by m
            ////elements. The dimensions and the elements should be read from the
            ////console. Find a platform with size of (3, 3) with a maximal sum.
            //Chap07_Arrays.Thirteen.RunThirteen();
            
            ////14. Write a program, which finds the longest sequence of equal string
            ////elements in a matrix. A sequence in a matrix we define as a set of
            ////neighbor elements on the same row, column or diagonal.
            ////REFER BOOK FOR GRIDS
            //Chap07_Arrays.Fourteen.RunFourteen();
            
            ////15. Write a program, which creates an array containing all Latin letters.
            ////The user inputs a word from the console and as result the program
            ////prints to the console the indices of the letters from the word.
            //Chap07_Arrays.Fifteen.RunFifteen();
            
            ////16. Write a program, which uses a binary search in a sorted array of
            ////integer numbers to find a certain element.
            //Chap07_Arrays.Sixteen.RunSixteen();
            
            ////17. Write a program, which sorts an array of integer elements using a "merge
            ////sort" algorithm.
            //Chap07_Arrays.Seventeen.RunSeventeen();
            
            ////18. Write a program, which sorts an array of integer elements using a "quick
            ////sort" algorithm.
            //Chap07_Arrays.Eighteen.RunEighteen();
            
            ////19. Write a program, which finds all prime numbers in the range
            ////[1…10,000,000].
            //Chap07_Arrays.Nineteen.RunNineteen();
            
            ////20. * Write a program, which checks whether there is a subset of given
            ////array of N elements, which has a sum S. The numbers N, S and the array
            ////values are read from the console. Same number can be used many times.
            ////Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6 = 14)
            //Chap07_Arrays.Twenty.RunTwenty();
            
            ////21. Write a program which by given N numbers, K and S, finds K elements out
            ////of the N numbers, the sum of which is exactly S or says it is not possible.
            ////Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 -> yes (1 + 2 + 4 = 14)
            //Chap07_Arrays.Twentyone.RunTwentyone();
            
            ////22. Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements in such a way that the remaining array is sorted in an increasing order.
            ////Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
            //Chap07_Arrays.Twentytwo.RunTwentytwo();
            
            ////23. Write a program, which reads the integer numbers N and K from the console and prints all variations of K elements of the numbers in the interval [1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.
            //Chap07_Arrays.Twentythree.RunTwentythree();
            
            ////24. Write a program, which reads an integer number N from the console and prints all combinations of K elements of numbers in range [1 … N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.
            //Chap07_Arrays.Twentyfour.RunTwentyfour();
            
            ////25. *Write a program, which finds in a given matrix the largest area of equal numbers. We define an area in the matrix as a set of neighbor cells (by row and column). Here is one example with an area containing 13 elements with equal value of 3:
            ////REFER BOOK FOR GRIDS
            //Chap07_Arrays.Twentyfive.RunTwentyfive();
        }

    }

    public static class Chap08 //Numerial Systems
    {
        public static void RunChap08()
        {
            //NOT STARTED

            //1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
            Chap08_NumeralSystems.One.RunOne();
            
            //2. Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
            Chap08_NumeralSystems.Two.RunTwo();
            
            //3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
            Chap08_NumeralSystems.Three.RunThree();
            
            //4. Write a program that converts a decimal number to binary one.
            Chap08_NumeralSystems.Four.RunFour();
            
            //5. Write a program that converts a binary number to decimal one.
            Chap08_NumeralSystems.Five.RunFive();
            
            //6. Write a program that converts a decimal number to hexadecimal one.
            Chap08_NumeralSystems.Six.RunSix();
            
            //7. Write a program that converts a hexadecimal number to decimal one.
            Chap08_NumeralSystems.Seven.RunSeven();
            
            //8. Write a program that converts a hexadecimal number to binary one.
            Chap08_NumeralSystems.Eight.RunEight();
            
            //9. Write a program that converts a binary number to hexadecimal one.
            Chap08_NumeralSystems.Nine.RunNine();
            
            //10. Write a program that converts a binary number to decimal using the Horner scheme.
            Chap08_NumeralSystems.Ten.RunTen();
            
            //11. Write a program that converts Roman digits to Arabic ones.
            Chap08_NumeralSystems.Eleven.RunEleven();
            
            //12. Write a program that converts Arabic digits to Roman ones.
            Chap08_NumeralSystems.Twelve.RunTwelve();
            
            //13. Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.
            Chap08_NumeralSystems.Thirteen.RunThirteen();
            
            //14. Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). Try it with float and double and after that with decimal. Do you notice the huge difference in the results and speed of calculation? Explain what happens.
            Chap08_NumeralSystems.Fourteen.RunFourteen();
            
            //15. * Write a program that prints the value of the mantissa, the sign of the mantissa and exponent in
            //float numbers (32-bit numbers with a floating-point according to the IEEE 754 standard). Example: for the number -27.25 should be printed: sign = 1,
            //exponent = 10000011, mantissa = 10110100000000000000000.
            Chap08_NumeralSystems.Fifteen.RunFifteen();

        }

    }

    public static class Chap09 //Methods
    {
        public static void RunChap09()
        { 
            //1. Write a code that by given name prints on the console "Hello, <name>!" (for example: "Hello, Peter!").
            //Chap09_Methods.One.RunOne(); //CORRECT
            //2. Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. Write a test program that validates that the methods works correctly.
            //Chap09_Methods.Two.RunTwo(); //CORRECT
            //3. Write a method that returns the English name of the last digit of a given number. Example: for 512 prints "two"; for 1024  "four".
            //Chap09_Methods.Three.RunThree(); //CORRECT
            //4. Write a method that finds how many times certain number can be found in a given array. Write a program to test that the method works correctly.
            //Chap09_Methods.Four.RunFour(); //CORRECT
            //5. Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. Test whether the method works correctly.
            //Chap09_Methods.Five.RunFive(); //CORRECT
            //6. Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.
            //Chap09_Methods.Six.RunSix(); //CORRECT
            ////7. Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
            //Chap09_Methods.Seven.RunSeven(); //CORRRECT
            ////8. Write a method that calculates the sum of two very long positive integer numbers. The numbers are represented as array digits and the last digit (the ones) is stored in the array at index 0. Make the method work for all numbers with length up to 10,000 digits.
            //Chap09_Methods.Eight.RunEight(); //INCORRECT!!!
            ////9. Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.
            //Chap09_Methods.Nine.RunNine();
            ////10. Write a program that calculates and prints the n! for any n in the range [1…100].
            //Chap09_Methods.Ten.RunTen();
            ////11. Write a program that solves the following tasks:
            ////- Put the digits from an integer number into a reversed order.
            ////- Calculate the average of given sequence of numbers.
            ////- Solve the linear equation a * x + b = 0.
            ////Create appropriate methods for each of the above tasks.
            ////Make the program show a text menu to the user. By choosing an option of that menu, the user will be able to choose which task to be invoked.
            ////Perform validation of the input data:
            ////- The integer number must be a positive in the range [1…50,000,000].
            ////- The sequence of numbers cannot be empty.
            ////- The coefficient a must be non-zero.
            //Chap09_Methods.Eleven.RunEleven();
            ////12. Write a method that calculates the sum of two polynomials with integer coefficients, for example (3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).
            //Chap09_Methods.Twelve.RunTwelve();
            ////13. * Write a method that calculates the product of two polynomials with integer coefficients, for example (3x2 + x - 3) * (x - 1) = (3x3 - 2x2 - 4x + 3).
            //Chap09_Methods.Thirteen.RunThirteen();
        }

    }

    public static class Chap10 //Recursion
    {
        public static void RunChap10()
        {
            //1. Write a program to simulate n nested loops from 1 to n.
            Chap10_Recursion.One.RunOne();
            
            //2. Write a program to generate all variations with duplicates of n elements class k. Sample input:
            //n = 3
            //k = 2
            //Sample output:
            //(1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3)
            //Think about and implement an iterative algorithm for the same task.
            Chap10_Recursion.Two.RunTwo();
            
            //3. Write a program to generate and print all combinations with duplicates of k elements from a set with n elements. Sample input:
            //Chapter 10. Recursion 379
            //n = 3
            //k = 2
            //Sample output:
            //(1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
            //Think about and implement an iterative algorithm for the same task.
            Chap10_Recursion.Three.RunThree();
            
            //4. You are given a set of strings. Write a recursive program, which generates all subsets, consisting exactly k strings chosen among the elements of this set. Sample input:
            //strings = {'test', 'rock', 'fun'}
            //k = 2
            //Sample output:
            //(test rock), (test fun), (rock fun)
            //Think about and implement an iterative algorithm as well.
            Chap10_Recursion.Four.RunFour();
            
            //5. Write a recursive program, which prints all subsets of a given set of N words. Example input:
            //words = {'test', 'rock', 'fun'}
            //Example output:
            //(), (test), (rock), (fun), (test rock), (test fun),
            //(rock fun), (test rock fun)
            //Think about and implement an iterative algorithm for the same task.
            Chap10_Recursion.Five.RunFive();
            
            //6. Implement the merge-sort algorithm recursively. In it the initial array is divided into two equal in size parts, which are sorted (recursively via merge-sort) and after that the two sorted parts are merged in order to get the whole sorted array.
            Chap10_Recursion.Six.RunSix();
            
            //7. Write a recursive program, which generates and prints all permutations of the numbers 1, 2, …, n, for a given integer n. Example input:
            //n = 3
            //Example output:
            //(1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)
            //Try to find an iterative solution for generating permutations.
            Chap10_Recursion.Seven.RunSeven();
            
            //8. You are given an array of integers and a number N. Write a recursive program that finds all subsets of numbers in the array, which have a sum N. For example, if we have the array {2, 3, 1, -1} and N=4, we can obtain N=4 as a sum in the following two ways: 4=2+3-1; 4=3+1.
            Chap10_Recursion.Eight.RunEight();
            
            //9. You are given an array of positive integers. Write a program that checks whether there is one or more numbers in the array (subset), whose sum is equal to S. Can you solve the task efficiently for large arrays?
            Chap10_Recursion.Nine.RunNine();
            
            //10. You are given a matrix with passable and impassable cells. Write a recursive program that finds all paths between two cells in the matrix.
            Chap10_Recursion.Ten.RunTen();
            
            //11. Implement the algorithm BFS (breadth-first search) for finding the shortest path in a labyrinth.
            Chap10_Recursion.Eleven.RunEleven();
            
            //12. Modify the previous program to check whether a path exists between two cells without finding all possible paths. Test the program with a matrix 100x100 filled only with passable cells.
            Chap10_Recursion.Twelve.RunTwelve();
            
            //13. You are given a matrix with passable and impassable cells. Write a program that finds the largest area of neighboring passable cells.
            Chap10_Recursion.Thirteen.RunThirteen();
            
            //14. Write a recursive program that traverses the whole hard disk C:\ recursively and prints all folders and files.
            Chap10_Recursion.Fourteen.RunFourteen();

        }

    }



    public static class Chap11 //Creating and Using Objects
    {
        public static void RunChap11()
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
        }
    }
    public static class Chap12 //Exception Handling
    {
        public static void RunChap12()
        {
            //1. Find out all exceptions in the System.IO.IOException hierarchy.
            //2. Find out all standard exceptions that are part of the hierarchy holding the class System.IO.FileNotFoundException.
            //3. Find out all standard exceptions from System.ApplicationException hierarchy.
            //4. Explain the concept of exceptions and exception handling, when they are used and how to catch exceptions.
            //5. Explain when the statement try-finally is used. Explain the relationship between the statements try-finally and using.
            //6. Explain the advantages when using exceptions.
            //454 Fundamentals of Computer Programming with C#
            //7. Write a program that takes a positive integer from the console and prints the square root of this integer. If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye".
            //8. Write a method ReadNumber(int start, int end) that reads an integer from the console in the range [start…end]. In case the input integer is not valid or it is not in the required range throw appropriate exception. Using this method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1 < … < a10 < 100.
            //9. Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string. What should the method do if and exception is thrown?
            //10. Write a method that takes as a parameter the name of a binary file, reads the content of the file and returns it as an array of bytes. Write a method that writes the file content to another file. Compare both files.
            //11. Search for information in Internet and define your own class for exception FileParseException. The exception has to contain the name of the processed file and the number of the row where the problem is occurred. Add appropriate constructors in the exception. Write a program that reads integers from a text file. If the during reading a row does not contain an integer throw FileParseException and pass it to the calling method.
            //12. Write a program that gets from the user the full path to a file (for example C:\Windows\win.ini), reads the content of the file and prints it to the console. Find in MSDN how to us the System.IO.File. ReadAllText(…) method. Make sure all possible exceptions will be caught and a user-friendly message will be printed on the console.
            //13. Write a program to download a file from Internet by given URL, e.g. http://introprogramming.info/wp-content/themes/introprograming_en/ images/Intro-Csharp-Book-front-cover-big_en.png.

        }

    }
    public static class Chap13 //Strings And Text Processing
    {
        public static void RunChap13()
        {
            //1. Describe the strings in C#. What is typical for the string type? Explain which the most important methods of the string class are.
            //2. Write a program that reads a string, reverse it and prints it to the console. For example: "introduction"  "noitcudortni".
            //3. Write a program that checks whether the parentheses are placed correctly in an arithmetic expression. Example of expression with correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).
            //4. How many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash?
            //Example: one\two\three.
            //Note: In C# backslash is an escaping character.
            //5. Write a program that detects how many times a substring is contained in the text. For example, let’s look for the substring "in" in the text:
            //We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
            //The result is 9 occurrences.
            //6. A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.
            //Example:
            //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            //Result:
            //We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
            //7. Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with "*" to 20 characters.
            //8. Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language. Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".
            //9. Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code. The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.
            //Sample source text: "Test". Sample cipher code: "ab". The result should be the following: "\u0035\u0007\u0012\u0016".
            //10. Write a program that extracts from a text all sentences that contain a particular word. We accept that the sentences are separated from each other by the character "." and the words are separated from one another by a character which is not a letter. Sample text:
            //We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking
            //all the day. We will move out of it in 5 days.
            //Sample result:
            //We are living in a yellow submarine.
            //We will move out of it in 5 days.
            //11. A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks. Sample text:
            //Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.
            //Sample string containing the forbidden words: "C#,CLR,Microsoft".
            //Sample result:
            //********* announced its next generation ** compiler today. It uses advanced parser and special optimizer for the ********* ***.
            //12. Write a program that reads a number from console and prints it in 15-character field, aligned right in several ways: as a decimal number, hexadecimal number, percentage, currency and exponential (scientific) notation.
            //13. Write a program that parses an URL in following format:
            //[protocol]://[server]/[resource]
            //It should extract from the URL the protocol, server and resource parts. For example, when http://www.cnn.com/video is passed, the result is:
            //[protocol]="http"
            //[server]="www.cnn.com"
            //[resource]="/video"
            //14. Write a program that reverses the words in a given sentence without changing punctuation and spaces. For example: "C# is not C++ and PHP is not Delphi"  "Delphi not is PHP and C++ not is C#".
            //15. A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen:
            //.NET – platform for applications from Microsoft
            //494 Fundamentals of Computer Programming with C#
            //CLR – managed execution environment for .NET namespace – hierarchical organization of classes
            //Write a program that parses the dictionary and then reads words from the console in a loop, gives an explanation for it or writes a message on the console that the word is not into the dictionary.
            //16. Write a program that replaces all hyperlinks in a HTML document consisting of <a href="…">…</a> and hyperlinks in "forum" style, which look like [URL=…]…[/URL].
            //Sample text:
            //<p>Please visit <a href="http://softuni.org">our site</a> to choose a training course. Also visit <a href= "http://forum.softuni.org">our forum</a> to discuss the courses.</p>
            //Sample result:
            //<p>Please visit [URL=http://softuni.org]our site[/URL] to choose a training course. Also visit [URL= http://forum.softuni.org]our forum[/URL] to discuss the courses.</p>
            //17. Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
            //Enter the first date: 27.02.2006
            //Enter the second date: 3.03.2006
            //Distance: 4 days
            //18. Write a program that reads the date and time entered in the format "day.month.year hour:minutes:seconds" and prints the date and time after 6 hours and 30 minutes in the same format.
            //19. Write a program that extracts all e-mail addresses from a text. These are all substrings that are limited on both sides by text end or separator between words and match the shape <sender>@<host>…<domain>. Sample text:
            //Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.
            //Extracted e-mail addresses from the sample text:
            //example@gmail.com
            //test.user@yahoo.co.uk
            //20. Write a program that extracts from a text all dates written in format DD.MM.YYYY and prints them on the console in the standard format for Canada. Sample text:
            //I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).
            //Extracted dates from the sample text:
            //14.06.1980
            //3.7.1984
            //21. Write a program that extracts from a text all words which are palindromes, such as ABBA", "lamal", "exe".
            //22. Write a program that reads a string from the console and prints in alphabetical order all letters from the input string and how many times each one of them occurs in the string.
            //23. Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string.
            //24. Write a program that reads a string from the console and replaces every sequence of identical letters in it with a single letter (the repeating letter). Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
            //25. Write a program that reads a list of words separated by commas from the console and prints them in alphabetical order (after sorting).
            //26. Write a program that extracts all the text without any tags and attribute values from an HTML document.
            //Sample text:
            //<html>
            //<head><title>News</title></head>
            //<body><p><a href="http://softuni.org">Software
            //University</a>aims to provide free real-world practical
            //training for young people who want to turn into
            //skillful software engineers.</p></body>
            //</html>
            //Sample result:
            //News
            //Software University aims to provide free real-world practical training for young people who want to turn into skillful software engineers.
        }

    }

    public static class Chap14 //Defining Classes
    {
        public static void RunChap14()
        {
            //need to go overcode, reformat to question answer format etc
        }

    }

    public static class Chap15 //Text Files
    {
        public static void RunChap15()
        {
            //Chap15_TextFiles.One.RunOne();            //CORRECT
            //Chap15_TextFiles.Two.RunTwo();            //CORRECT
            //Chap15_TextFiles.Three.RunThree();        //CORRECT
            //Chap15_TextFiles.Four.RunFour();          //CORRECT
            Chap15_TextFiles.Five.RunFive();          //started
            //Chap15_TextFiles.Six.RunSix();            //not started
            //Chap15_TextFiles.Seven.RunSeven();/       //not started
            //Chap15_TextFiles.Eight.RunEight();        //not started
            //Chap15_TextFiles.Nine.RunNine();          //not started
            //Chap15_TextFiles.Ten.RunTen();            //not started
            //Chap15_TextFiles.Eleven.RunEleven();      //not started
            //Chap15_TextFiles.Twelve.RunTwelve();      //not started
            //Chap15_TextFiles.Thirteen.RunThirteen();  //not started
        }

    }


    public static class Chap16 //Linear Data Structures
    {
        public static void RunChap16()
        {
            //Chap16_LinearDataStructures.ExOneTest.RunExOneTest(); //COMPLETE
            //Chap16_LinearDataStructures.ExTwoTest.RunExTwoTest(); //COMPLETE
            //Chap16_LinearDataStructures.ExThree.RunExThreeTest(); //COMPLETE
            //Chap16_LinearDataStructures.ExFour.RunExFour();       //NOT WORKING
            //Chap16_LinearDataStructures.ExFive.RunExFive();       //COMPLETE
            //Chap16_LinearDataStructures.ExSix.RunExSix();         //COMPLETE - Slow solution fast solution uses has table (next)
            //Chap16_LinearDataStructures.ExSix.RunExSixFast();     //NOT COMPLETE - Come back to once finished chap18 (Dictionaries)
            //Chap16_LinearDataStructures.ExSeven.RunExSeven();     //COMPLETE
            //Chap16_LinearDataStructures.ExEight.RunExEight();     //COMPLETE
            //Chap16_LinearDataStructures.Nine.RunNine();           //NOT COMPLETE - cant figure out how to get to the next element in the array due to enumerables being readonly
            //Chap16_LinearDataStructures.Ten.RunTen();             //COMPLETE - think this is correct?? - probabaly not..
            //Chap16_LinearDataStructures.Eleven.RunEleven();       //NOT STARTED - Implementing doubly linked list...  (finished code, but stolen for reference) need to redo?
            Chap16_LinearDataStructures.Twelve.RunTwelve();
            //Chap16_LinearDataStructures.Thirteen.RunThirteen();
            //Chap16_LinearDataStructures.Fourteen.RunFourteen();
            //Chap16_LinearDataStructures.Fifteen.RunFifteen();
            //Chap16_LinearDataStructures.Sixteen.RunSixteen();
            //Chap16_LinearDataStructures.Seventeen.RunSeventeen();
            //Chap16_LinearDataStructures.Eighteen.ReunEighteen();
        }

    }

    public static class Chap17 //Trees and Graphs
    {
        public static void RunChap17()
        {

        }

    }

    public static class Chap18 //Dictionaries, HAshtables and Sets
    {
        public static void RunChap18()
        {

        }

    }

    public static class Chap19 //Data Structures and Alogorithm Complexity
    {
        public static void RunChap19()
        {

        }

    }

    public static class Chap20 //Object-Oriented Programming Principles
    {
        public static void RunChap20()
        {

        }

    }

    public static class Chap21 //High-Quality Programming Code
    {
        public static void RunChap21()
        {

        }

    }

    public static class Chap22 //Lambda Expressions and LINQ
    {
        public static void RunChap22()
        {

        }

    }

    public static class Chap23 //Methodology of Problem Solving
    {
        public static void RunChap23()
        {

        }

    }

    public static class Chap24 //Sample Programming Exam - Topic1
    {
        public static void RunChap24()
        {

        }

    }

    public static class Chap25 //Sample Programming Exam - Topic2
    {
        public static void RunChap25()
        {

        }

    }

    public static class Chap26 //Sample Programming Exam - Topic3
    {
        public static void RunChap26()
        {

        }

    }
}
