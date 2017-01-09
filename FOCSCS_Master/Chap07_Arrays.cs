using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap07_Arrays
    {

        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE
        //04    -   COMPLETE
        //05    -   COMPLETEish
        //06    -   
        //07    -   
        //08    -   
        //09    -   
        //10    -   
        //11    -   
        //12    -   
        //13    -   
        //14    -   
        //15    -   
        //16    -   
        //17    -   
        //18    -   
        //19    -   
        //20    -   
        //21    -   
        //22    -   
        //23    -   
        //24    -   
        //25    -   

        //  5/25 COMPLETED




        public static class One
        {
            //1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("7.1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.");
                Console.WriteLine();

                int[] myArr = new int[20];
                for (int i = 0; i < myArr.Length; i++)
                {
                    myArr[i] = i * 5;
                    Console.WriteLine(myArr[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Correct");
            }
        }

        public static class Two
        {
            //2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("7.2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).");
                Console.WriteLine();

                int[] firstArr = new int[20];
                int[] secArr = new int[20];

                for (int i = 0; i < firstArr.Length; i++)
                {
                    firstArr[i] = i;
                    secArr[i] = i + 1;
                }

                bool equal = firstArr.SequenceEqual(secArr);
                if (firstArr.Length == secArr.Length)
                {

                    if (equal)
                    {
                        Console.WriteLine("Arrays are equal");
                    }
                    else
                    {
                        Console.WriteLine("Arrays are not equal (different elements)");
                    }
                }
                else
                {
                    Console.WriteLine("Arrays are not equal (different lengths)");
                }

                Console.WriteLine("CORRECT");
            }

        }

        public static class Three
        {
            //7.3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("7.3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.");
                Console.WriteLine();

                char[] firstChars = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
                char[] secondChars = new char[10] { 'g', 'l', 'm', 'a', 'b', 'c', 'r', 'z', 'i', 'b' };

                int[] results = new int[10];

                for (int i = 0; i < firstChars.Length; i++)
                {
                    results[i] = String.CompareOrdinal(firstChars[i].ToString(), secondChars[i].ToString());
                    if (results[i] < 0)
                    {
                        Console.WriteLine("The first array at position {0} is lexigraphically less than the Second Array at position {0}", i);
                    }
                    else if (results[i] > 0)
                    {
                        Console.WriteLine("The first array at position {0} is lexigraphically more than the second array at position {0}", i);
                    }
                    else
                    {
                        Console.WriteLine("Both elements at position {0} are equal", i);
                    }

                    Console.WriteLine("CORRECT");
                }
            }
        }

        public static class Four
        {
            //7.4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.

            //Scan the array from left to right. Every time when the current number is different from the one before it, a new sequence starts.
            //If the current element is equal to the one before it, it is a continuation of the same sequence. So, if we keep the index of
            //the start position of the current sequence (in the beginning it is 0) in start and the length of the current sequence
            //(in the beginning it is 1) in len, we can find all sequences of equal elements and their lengths. We can easily keep
            //the shortest one in two additional variables – bestStart and bestLen.
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.");
                Console.WriteLine();

                int[] myInts = new int[] { 1, 1, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1 };

                string toPrint = "{";
                Console.WriteLine("Current array to check:");
                for (int i = 0; i < myInts.Length; i++)
                {
                    toPrint += myInts[i] + ", ";
                }
                toPrint = toPrint.Substring(0, toPrint.Length - 2);
                toPrint += "}";
                Console.WriteLine(toPrint);
                Console.WriteLine();

                int bestStartIndex = 0;
                int bestLen = 0;
                int currentLength = 0;

                for (int i = 1; i < myInts.Length - 1; i++)
                {
                    if (myInts[i] != myInts[i - 1])
                    {
                        currentLength = 0;
                    }
                    else if (myInts[i] == myInts[i - 1])
                    {
                        currentLength++;
                        if (currentLength > bestLen)
                        {
                            bestLen = currentLength;
                            bestStartIndex = i - currentLength;
                        }
                    }
                }

                toPrint = "{";
                Console.WriteLine("Maximal sequence of consecutive equal elements in array:");
                for (int i = 0; i < bestLen + 1; i++)
                {
                    toPrint += (myInts[bestStartIndex + i] + ", ");
                }
                toPrint = toPrint.Substring(0, toPrint.Length - 2);
                toPrint += "}";
                Console.WriteLine(toPrint);

                Console.WriteLine();
                Console.WriteLine("CORRECT");
            }
        }




        public static class Five
        {
            //7.5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.");
                Console.WriteLine();


                int[] myInts = new int[] { 3, 2, 3, 4, 5 ,6, 2, 2, 4 , 8,9,10,11};

                string toPrint = "{";
                Console.WriteLine("Current array to check:");
                for (int i = 0; i < myInts.Length; i++)
                {
                    toPrint += myInts[i] + ", ";
                }
                toPrint = toPrint.Substring(0, toPrint.Length - 2);
                toPrint += "}";
                Console.WriteLine(toPrint);
                Console.WriteLine();

                int bestStartIndex = 0;
                int bestLen = 0;
                int currentLength = 0;

                for (int i = 1; i < myInts.Length - 1; i++)
                {
                    if (myInts[i] != myInts[i - 1]+1)
                    {
                        currentLength = 0;
                    }
                    else if (myInts[i] == myInts[i - 1]+1)
                    {
                        currentLength++;
                        if (currentLength > bestLen)
                        {
                            bestLen = currentLength;
                            bestStartIndex = i - currentLength;
                        }
                    }
                }

                toPrint = "{";
                Console.WriteLine("Maximal sequence of consecutively placed increasing integers in array:");
                for (int i = 0; i < bestLen + 1; i++)
                {
                    toPrint += (myInts[bestStartIndex + i] + ", ");
                }
                toPrint = toPrint.Substring(0, toPrint.Length - 2);
                toPrint += "}";
                Console.WriteLine(toPrint);

                Console.WriteLine();
                Console.WriteLine("CORRECT --ish, close enough but needs fixing (try putting in differnt sequences and sometimes the end gets chopped off (last element in array??)");
            }
        }

        public static class Six
        {
            //7.6. Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}.
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.6. Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}.");
                Console.WriteLine();
            }
        }

        public static class Seven
        {
            //7.7. Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("7.7. Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.");
                Console.WriteLine();
            }
        }

        public static class Eight
        {
            //7.8. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm "selection sort".
            
            //GUIDELINES:
            //Find in Internet information about "Selection sort" and its C# implementations. Briefly the idea is to find the smallest element and to
            //place it at position 0 (through swapping) then to find the smallest number excluding the first and place it at position 1 and so on,
            //until the entire array is arranged in ascending order.
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("7.8. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm \"selection sort\".");
                Console.WriteLine();

                //int[] myArr = new int[10] { 2, 45, 753, 431, 8, 231, 34456, 645, 35, 54 };
                int[] myArr = new int[10] { 1324, 315, 312, 222 , 121, 100, 67, 45, 23, 12 };

                SortIntArray(myArr);

                for (int i = 0; i < myArr.Length; i++)
                {
                    Console.WriteLine(myArr[i]);
                }

            }

            public static void SortIntArray(int[] myArr)
            {
                for (int j = 0; j < myArr.Length; j++)
                {
                    for (int i = 0; i < myArr.Length; i++)
                    {
                        if (i < myArr.Length - 1)
                        {
                            if (myArr[i] > myArr[i + 1])
                            {
                                int temp = myArr[i];
                                myArr[i] = myArr[i + 1];
                                myArr[i + 1] = temp;
                            }
                        }
                    }
                }

            }
        }

        public static class Nine
        {
            //7.9. Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.9. Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11");
                Console.WriteLine();
            }
        }

        public static class Ten
        {
            //7.10. Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.10. Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).");
                Console.WriteLine();
            }
        }

        public static class Eleven
        {
            //7.11. Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}.
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.11. Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}.");
                Console.WriteLine();
            }
        }
        public static class Twelve
        {
            //7.12. Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion:
            //REFER BOOK FOR GRIDS
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("7.12. Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion:");
                Console.WriteLine("REFER BOOK FOR GRIDS");
                Console.WriteLine();
            }
        }
        public static class Thirteen
        {
            //7.13. Write a program, which creates a rectangular array with size of n by m
            //elements. The dimensions and the elements should be read from the
            //console. Find a platform with size of (3, 3) with a maximal sum.
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.13. Write a program, which creates a rectangular array with size of n by m");
                Console.WriteLine("elements. The dimensions and the elements should be read from the");
                Console.WriteLine("console. Find a platform with size of (3, 3) with a maximal sum.");
                Console.WriteLine();
            }
        }

        public static class Fourteen
        {
            //7.14. Write a program, which finds the longest sequence of equal string
            //elements in a matrix. A sequence in a matrix we define as a set of
            //neighbor elements on the same row, column or diagonal.
            //REFER BOOK FOR GRIDS
            public static void RunFourteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.14. Write a program, which finds the longest sequence of equal string");
                Console.WriteLine("elements in a matrix. A sequence in a matrix we define as a set of");
                Console.WriteLine("neighbor elements on the same row, column or diagonal.");
                Console.WriteLine("REFER BOOK FOR GRIDS");
                Console.WriteLine();
            }
        }

        public static class Fifteen
        {
            //7.15. Write a program, which creates an array containing all Latin letters.
            //The user inputs a word from the console and as result the program
            //prints to the console the indices of the letters from the word.
            public static void RunFifteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.15. Write a program, which creates an array containing all Latin letters.");
                Console.WriteLine("The user inputs a word from the console and as result the program");
                Console.WriteLine("prints to the console the indices of the letters from the word.");
                Console.WriteLine();
            }
        }

        public static class Sixteen
        {
            //7.16. Write a program, which uses a binary search in a sorted array of
            //integer numbers to find a certain element.
            public static void RunSixteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.16. Write a program, which uses a binary search in a sorted array of");
                Console.WriteLine("integer numbers to find a certain element.");
                Console.WriteLine();
            }
        }

        public static class Seventeen
        {
            //7.17. Write a program, which sorts an array of integer elements using a "merge
            //sort" algorithm.
            public static void RunSeventeen()
            {
                Console.WriteLine();
                Console.WriteLine("7.17. Write a program, which sorts an array of integer elements using a \"merge");
                Console.WriteLine("sort\" algorithm.");
                Console.WriteLine();
            }
        }

        public static class Eighteen
        {
            //7.18. Write a program, which sorts an array of integer elements using a "quick
            //sort" algorithm.
            public static void RunEighteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.18. Write a program, which sorts an array of integer elements using a \"quick");
                Console.WriteLine("sort\" algorithm.");
                Console.WriteLine();
            }
        }

        public static class Nineteen
        {
            //7.19. Write a program, which finds all prime numbers in the range
            //[1…10,000,000].
            public static void RunNineteen()
            {
                Console.WriteLine();
                Console.WriteLine("7.19. Write a program, which finds all prime numbers in the range");
                Console.WriteLine("[1…10,000,000].");
                Console.WriteLine();
            }
        }

        public static class Twenty
        {
            //7.20. * Write a program, which checks whether there is a subset of given
            //array of N elements, which has a sum S. The numbers N, S and the array
            //values are read from the console. Same number can be used many times.
            //Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6 = 14)
            public static void RunTwenty()
            {
                Console.WriteLine();
                Console.WriteLine("7.20. * Write a program, which checks whether there is a subset of given");
                Console.WriteLine("array of N elements, which has a sum S. The numbers N, S and the array");
                Console.WriteLine("values are read from the console. Same number can be used many times.");
                Console.WriteLine(@"Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6 = 14)");
                Console.WriteLine();
            }
        }


        public static class Twentyone
        {
            //7.21. Write a program which by given N numbers, K and S, finds K elements out
            //of the N numbers, the sum of which is exactly S or says it is not possible.
            //Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 -> yes (1 + 2 + 4 = 14)
            public static void RunTwentyone()
            {
                Console.WriteLine();
                Console.WriteLine("7.21. Write a program which by given N numbers, K and S, finds K elements out");
                Console.WriteLine("of the N numbers, the sum of which is exactly S or says it is not possible.");
                Console.WriteLine(@"Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 -> yes (1 + 2 + 4 = 14)");
                Console.WriteLine();
            }
        }


        public static class Twentytwo
        {
            //7.22. Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements in such a way that the remaining array is sorted in an increasing order.
            //Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
            public static void RunTwentytwo()
            {
                Console.WriteLine();
                Console.WriteLine("7.22. Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements in such a way that the remaining array is sorted in an increasing order.");
                Console.WriteLine(@"Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}");
                Console.WriteLine();
            }
        }


        public static class Twentythree
        {
            //7.23. Write a program, which reads the integer numbers N and K from the console and prints all variations of K elements of the numbers in the interval [1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.
            public static void RunTwentythree()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.23. Write a program, which reads the integer numbers N and K from the console and prints all variations of K elements of the numbers in the interval [1…N]. Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.");
                Console.WriteLine();
            }
        }


        public static class Twentyfour
        {
            //7.24. Write a program, which reads an integer number N from the console and prints all combinations of K elements of numbers in range [1 … N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.
            public static void RunTwentyfour()
            {
                Console.WriteLine();
                Console.WriteLine(@"7.24. Write a program, which reads an integer number N from the console and prints all combinations of K elements of numbers in range [1 … N]. Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.");
                Console.WriteLine();
            }
        }

        public static class Twentyfive
        {
            //7.25. *Write a program, which finds in a given matrix the largest area of equal numbers. We define an area in the matrix as a set of neighbor cells (by row and column). Here is one example with an area containing 13 elements with equal value of 3:
            //REFER BOOK FOR GRIDS
            public static void RunTwentyfive()
            {
                Console.WriteLine();
                Console.WriteLine("7.25. *Write a program, which finds in a given matrix the largest area of equal numbers. We define an area in the matrix as a set of neighbor cells (by row and column). Here is one example with an area containing 13 elements with equal value of 3:");
                Console.WriteLine("REFER BOOK FOR GRIDS");
                Console.WriteLine();
            }
        }


    }
}
