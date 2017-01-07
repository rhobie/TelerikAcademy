using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    //THESE EXERCISES HAVE A LOT OF DIAGRAMS, BETTER TO WORK FROM THE BOOK

    //1. Using the described in this chapter methodology of solving programming problems, solve this problem: In a plane N points are given (N < 100,000). The coordinates of the points are integers (xi, yi). Write a program, which finds all horizontal and vertical lines, such that they split the plane into two parts, each containing an equal set of points (points lying on the line are note counted).
    //2. Using the described in this chapter methodology of solving programming problems, solve this problem: A set S of n integers and a positive integer k (k ≤ n ≤ 10) are given. An alternating sequence is a sequence, which changes its behavior from ascending to descending and vice versa after every element. Write a program, which generates all possible sequences s1, s2, …, sk containing k different elements from S.
    //Example: S = { 2, 5, 3, 4 }, K = 3: {2, 4, 3}, {2, 5, 3}, {2, 5, 4}, {3, 2, 4}, {3, 2, 5}, {3, 4, 2}, {3, 5, 2}, {3, 5, 4}, {4, 2, 3}, {4, 2, 5}, {4, 3, 5}, {4, 5, 2}, {4, 5, 3}, {5, 2, 3}, {5, 2, 4}, {5, 3, 4}.
    //3. Using the described methodology of creating solutions to programming problems, solve the following problem: a map of a city is given. At this map there are given roads and crossroads. For every road a length is given. One crossroad can connect a couple of roads. Your program must find the shortest path from one crossroad to another (the shortest path is measured as the sum of the lengths of all includes roads).
    //A sample map is given below. At this map the shortest path between the crossings A and D has length of 70 and it is shown on the figure with bold lines. As you can see, this is not the only path from A to D: there are more paths with different lengths. Note that not always the first shortest road considered as current next node leads to finding the shortest path, neither does the lowest count of roads. Between some crossings there may not even be a road. This creates a very interesting problem.
    //Chapter 23. Methodology of Problem Solving 981
    //The input data is contained in the file map.txt. A list of the roads and their length are given first, followed by a blank line and the pairs of crossroads, between which we need to find the shortest path. At the end of the file a blank line is given. Crossroads are denoted by a single letter of sequence of letters. Here is a sample input file:
    //A B 20
    //A H 30
    //B H 5
    //…
    //L M 5
    //(blank line)
    //A D
    //H K
    //A E
    //(blank line)
    //The result from the execution of your program should be printed on the console in the following format: for every pair of crossroads from the input file, the shortest path length should be printed, followed by the path itself. For the map above the output will look like this:
    //70 ABJCFD
    //No path!
    //35 ABHE
    //4. * In a plane N points are given with integer positive coordinates. These points represent trees in a field. The gardener wants to enclose all trees using a minimum amount of fence. Write a program, which
    //20301030252520151510302045401551025StartEndADCEFGHIJB5KL10M5
    //982 Fundamentals of Computer Programming with C#
    //finds the appropriate points, through which the fence goes. Use the methodology of solving programming problems!
    //For example the garden may look like this:
    //The input data is read from the text file garden.txt. On the first line we are given N – the number of points is given. Next we are given N pairs – the coordinates of the points. For our example garden the file contains the following data:
    //13
    //60 50
    //100 30
    //40 40
    //20 70
    //50 20
    //30 70
    //10 10
    //110 70
    //90 60
    //80 20
    //70 80
    //20 20
    //30 60
    //The output data must be printed to the console as a sequence of points, through which the fence goes. Here is an output example:
    //01020304050607080901001101020304050607080(10, 10)(20, 20)(20, 70)(100, 30)(60, 50)(40, 40)(80, 20)(70, 80)(110, 70)(30, 60)(50, 20)(90, 60)(30, 70)
    //Chapter 23. Methodology of Problem Solving 983
    //(10, 10) - (20, 70) - (70, 80) - (110, 70) - (100, 30) - (80, 20) - (10, 10)
    class Chap23_MethodologyOfProblemSolving
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

    }
}
