using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    //1. Take the code from the first example in this chapter and refactor it to meet the quality standards discussed in this chapter.
    //2. Review your own code from the exercises from the previous chapters and find the mistakes you have made. Refactor the code to improve its quality. Think how you can avoid such mistakes and bad coding style in the future.
    //3. Open other people’s code and try to understand it only by reading the code itself. Is everything obvious at first sight? What would you change in that code, how would you write it?
    //Chapter 21. High-Quality Programming Code 913
    //4. Review the classes from .NET Common Type System (CTS). Can you find examples of low-quality code?
    //5. Have you used or seen any coding conventions? Having read this chapter, would you consider them good or bad?
    //6. We are given a square matrix of n x n cells. A rotating walk in the matrix is walk that starts from the top left corner of the matrix and goes in down-right direction. When no continuation is available at the current direction (either the matrix wall or non-empty cell is reached), the direction is changed to the next possible direction clockwise. The eight possible directions are as follows:
    //When no empty cell is available at all directions, the walk is restarted from an empty cell at the smallest possible row and as close as possible to the start of this row. When no empty cell is left in the matrix, the walk is finished. Your task is to write a program that reads from the console an integer number n (1 ≤ n ≤ 100) and displays the filled matrix on the console.
    //Sample input:
    //n = 6
    //Sample output:
    //1 16 17 18 19 20
    //15 2 27 28 29 21
    //14 31 3 26 30 22
    //13 36 32 4 25 23
    //12 35 34 33 5 24
    //11 10 9 8 7 6
    //REFER DIAGRAMS IN BOOK
    //Download a sample low-quality solution of that problem from here: http://introcsharpbook.googlecode.com/files/High-Quality-Code.rar.
    //Refactor the code so that it meets the recommended standards for quality code stated in this chapter. Note that fixing bugs in the solution might be necessary if it does not work correctly.
    class Chap21_High_QualityProgrammingCode
    {
        public static class One
        {
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Two
        {
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Three
        {
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Four
        {
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Five
        {
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Six
        {
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

    }
}
