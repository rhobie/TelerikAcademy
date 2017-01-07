using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap09_Methods
    {
        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPELTE
        //04    -   COMPLETE
        //05    -   COMPLETE
        //06    -   COMPLETE
        //07    -   COMPLETE
        //08    -   
        //09    -   
        //10    -   
        //11    -   
        //12    -   
        //13    -   


        public static class One
        {
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("09.1. Write a code that by given name prints on the console \"Hello, <name>!\" (for example: \"Hello, Peter!\").");
                Console.WriteLine();

                string name = GetName();
                PrintHello(name);

                Console.WriteLine("PASS");
            }

            public static string GetName()
            {
                Console.WriteLine("Please Enter Your Name");

                string name = Console.ReadLine();
                return name;

            }

            public static void PrintHello(string name)
            {
                Console.WriteLine("Hello {0}!", name);

            }
        }

        public static class Two
        {
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("09.2. Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. Write a test program that validates that the methods works correctly.");
                Console.WriteLine();


                int a;
                int b;
                int c;
                int max;

                PromptUserNums(out a, out b, out c);
                max = GetMax(a, b);
                max = GetMax(max, c);
                Console.WriteLine("Biggest of these three numbers is {0}", max);

                Console.WriteLine("PASS");
            }

            public static int GetMax(int a, int b)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }

            }

            public static void PromptUserNums(out int a, out int b, out int c) //int a, int b, int c
            {
                Console.WriteLine("Please enter three whole numbers, each followed by the enter key");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            }
        }

        public static class Three
        {
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("09.3. Write a method that returns the English name of the last digit of a given number. Example: for 512 prints \"two\"; for 1024 -> \"four\".");
                Console.WriteLine();

                int num = PromptMultiDigNum();

                Console.WriteLine(ConvertLastDigitToEnglish(num));

                Console.WriteLine("CORRECT");
            }

            public static int PromptMultiDigNum()
            {
                Console.WriteLine("Please enter a multi-digit number and I will attempt to print the last digit in english");
                int num = 0;
                while (num == 0 || num < 10)
                {
                    Int32.TryParse(Console.ReadLine(), out num);
                }
                return num;
            }

            public static string ConvertLastDigitToEnglish(int num)
            {
                int lastDigit = GetLastDigit(num);
                string english = ConvertDigitToEnglish(lastDigit);
                return english;
            }

            public static int GetLastDigit(int num)
            {
                num = num % 10;
                return num;
            }

            public static string ConvertDigitToEnglish(int num)
            {
                string s;
                switch (num)
                {
                    default:
                        s = "";
                        break;
                    case 1:
                        s = "One";
                        break;
                    case 2:
                        s = "Two";
                        break;
                    case 3:
                        s = "Three";
                        break;
                    case 4:
                        s = "Four";
                        break;
                    case 5:
                        s = "Five";
                        break;
                    case 6:
                        s = "Six";
                        break;
                    case 7:
                        s = "Seven";
                        break;
                    case 8:
                        s = "Eight";
                        break;
                    case 9:
                        s = "Nine";
                        break;
                    case 0:
                        s = "Zero";
                        break;
                }

                return s;
            }
        }

        public static class Four
        {
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("09.4. Write a method that finds how many times certain number can be found in a given array. Write a program to test that the method works correctly.");
                Console.WriteLine();

                int[] integerArr = new int[12] { 1, 5, 4, 3, 2, 1, 6, 8, 1, 7, 19, 4 };

                int num = GetIntFromConsole();

                Console.WriteLine("{0} appears {1} times in the stored array", num, CountNumOccurancesInArray(integerArr, num));

                Console.WriteLine("CORRECT");
            }
            public static int GetIntFromConsole()
            {
                int num = 0;

                while (num == 0)
                {
                    Console.WriteLine("Please enter a number to check the array for");
                    Int32.TryParse(Console.ReadLine(), out num);
                }

                return num;
            }

            public static int CountNumOccurancesInArray(int[] arr, int numToCheck)
            {
                int count = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (numToCheck == arr[i])
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public static class Five
        {
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("09.5. Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. Test whether the method works correctly.");
                Console.WriteLine();

                int[] integerArr = new int[20] { 1, 5, 4, 3, 2, 1, 6, 8, 1, 7, 19, 4, 324, 1, 35, 2435, 26, 24, 2466, 53 };

                int index = 999;
                while (index == 999 || index < 0 || index > 19)
                {
                    Console.WriteLine("Please enter an element index for the int array (20 elements total)");
                    Int32.TryParse(Console.ReadLine(), out index);
                }

                Console.WriteLine("chosen index ({1}) or array has a higher value ({2}) than that of both it's neighbours: {0}", ElementGreaterThanNeighbours(integerArr, index), index, integerArr[index]);
                Console.WriteLine("CORRECT");
            }
            public static bool ElementGreaterThanNeighbours(int[] arrInts, int indexToCheck)
            {
                if ((arrInts[indexToCheck] > arrInts[indexToCheck - 1]) && (arrInts[indexToCheck] > arrInts[indexToCheck + 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }

        public static class Six
        {
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("09.6. Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.");
                Console.WriteLine();

                int[] integerArr = new int[20] { 1, 5, 4, 3, 2, 1, 6, 8, 1, 7, 19, 4, 324, 1, 35, 2435, 26, 24, 2466, 53 };

                int value = 0;
                while (value == 0)
                {
                    Console.WriteLine("Please enter an value to search for in the array");
                    Int32.TryParse(Console.ReadLine(), out value);
                }

                int foundIndex = GetFirstOccurrenceOfAnElementFromAnArraySuchThatItIsGreaterThanItsTwoNeighborsSimultaneously(integerArr,value);



                Console.WriteLine("The first instance of the searched value ({1}) is at index {0}, (where its neighbours are also smaller) [if index is -1, then no susch value found", foundIndex, value);
                Console.WriteLine("CORRECT -apart from long method name");
            }


            public static int GetFirstOccurrenceOfAnElementFromAnArraySuchThatItIsGreaterThanItsTwoNeighborsSimultaneously(int[] arr, int serachFor)
            {
                int elementIndex = -1;
                int i = 0;
                foreach (var item in arr)
	            {
		            if (arr[i] == serachFor && arr[i] > arr[i+1] && arr[i] > arr[i-1])
                    {
                        elementIndex = i;
                    }
                    i++;
	            }
                return elementIndex;
            }
        }

        public static class Seven
        {
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("09.7. Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.");
                Console.WriteLine();

                int x = 0;
                while ( x <10)
                {
                    Console.WriteLine("please enter a multi-digit number");
                    Int32.TryParse(Console.ReadLine(), out x);
                }

                PrintIntReversed(x);

                Console.WriteLine("CORRECT");
            }

            public static void PrintIntReversed(int myInt)
            {
                string s = myInt.ToString();
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                string y = new string(charArray);

                Console.WriteLine("Chosen int reversered is: {0}",y);
            }
        }

        public static class Eight
        {
            //GUIDLELINES:
            //The reader must implement own method that calculates the sum of very big numbers.
            //The digits on position zero will keep the ones; the digit on the first position will keep the
            //tenths and so on. When two very big numbers are about to be calculated, the ones of their
            //sum will be equal to (firstNumber[0] + secondNumber[0]) % 10, the tenths on other side will
            //be equal to (firstNumber[1] + secondNumber[1]) % 10 + (firstNumber[0] + secondNumber[0])/10 and so on.

            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("09.8. Write a method that calculates the sum of two very long positive integer numbers. The numbers are represented as array digits and the last digit (the ones) is stored in the array at index 0. Make the method work for all numbers with length up to 10,000 digits.");
                Console.WriteLine();

                //3,214,598,785,462,154
                int[] arrOne = new int[16]{4,5,1,2,6,4,5,8,7,8,9,5,4,1,2,3};

                //1,557,854,158,646,845
                int[] arrTwo = new int[16]{5,4,8,6,4,6,8,5,1,4,5,8,7,5,5,1};

                int[] answer = AddIntArrays(arrOne, arrTwo);

                foreach (var item in answer)
                {
                    Console.WriteLine(item);
                }
                //answer should be: 4,772,452,944,108,999
                //currently get:    4,761,342,833,008,999
                //GOES WRONG SOMEWHERE IN THE MIDDLE?
                Console.WriteLine("INCORRECT");
            }
            public static int[] AddIntArrays(int[] arrOne, int[] arrTwo)
            {
                int[] resultArr = new int[16];

                int multiplier = 10;

                resultArr[0] = (arrOne[0] + arrTwo[0]) % 10;
                for (int i = 1; i < arrOne.Length; i++)
                {
                   resultArr[i] = (arrOne[i] + arrTwo[i]) % 10 + ((arrOne[i-1] + arrTwo[i-1]) / multiplier);
                   multiplier = multiplier * 10;
                }

                return resultArr;
            }
        }
                   // resultArr[i] = (arrOne[i] + arrTwo[i]) % 10;
                   // resultArr[i + 1] = (arrOne[i + 1] + arrTwo[i + 1]) % 10 + ((arrOne[i] + arrTwo[i]) / 10);


                   // resultArr[0] = (arrOne[0] + arrTwo[0]) % 10;
                   // resultArr[1] = (arrOne[1] + arrTwo[1]) % 10 + ((arrOne[0] + arrTwo[0]) / 10);
                   // resultArr[2] = (arrOne[2] + arrTwo[2]) % 10 + ((arrOne[1] + arrTwo[1]) / 100);
                   // resultArr[3] = (arrOne[3] + arrTwo[3]) % 10 + ((arrOne[2] + arrTwo[2]) / 1000);


                   //i=1 resultArr[i] = (arrOne[i] + arrTwo[i]) % 10 + ((arrOne[i-1] + arrTwo[i-1]) / multiplier);
                   //multiplier *= 10;
                   //i=2 resultArr[i] = (arrOne[i] + arrTwo[i]) % 10 + ((arrOne[i-1] + arrTwo[i-1]) / 100);
                   //i=3 resultArr[i] = (arrOne[i] + arrTwo[i]) % 10 + ((arrOne[i-1] + arrTwo[i-1]) / 1000);


        public static class Nine
        {
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("09.9. Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.");
                Console.WriteLine();
            }
        }




































        public static class Ten
        {
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("09.10. Write a program that calculates and prints the n! for any n in the range [1…100].");
                Console.WriteLine();
            }
        }

        public static class Eleven
        {
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("09.11. Write a program that solves the following tasks:");
                Console.WriteLine("- Put the digits from an integer number into a reversed order.");
                Console.WriteLine("- Calculate the average of given sequence of numbers.");
                Console.WriteLine("- Solve the linear equation a * x + b = 0.");
                Console.WriteLine("Create appropriate methods for each of the above tasks.");
                Console.WriteLine("Make the program show a text menu to the user. By choosing an option of that menu, the user will be able to choose which task to be invoked.");
                Console.WriteLine("Perform validation of the input data:");
                Console.WriteLine("- The integer number must be a positive in the range [1…50,000,000].");
                Console.WriteLine("- The sequence of numbers cannot be empty.");
                Console.WriteLine("- The coefficient a must be non-zero.");
                Console.WriteLine();


            }
        }


        public static class Twelve
        {
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("09.12. Write a method that calculates the sum of two polynomials with integer coefficients, for example (3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).");
                Console.WriteLine();
            }
        }

        public static class Thirteen
        {
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("09.13. * Write a method that calculates the product of two polynomials with integer coefficients, for example (3x2 + x - 3) * (x - 1) = (3x3 - 2x2 - 4x + 3).");
                Console.WriteLine();
            }
        }
    }
}