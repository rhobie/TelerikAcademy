using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap01_IntroductionToProgramming
    {
        public static class One
        {
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("01.1. Install and make yourself familiar with Microsoft Visual Studio and Microsoft Developer Network (MSDN) Library Documentation.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Two
        {
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("01.2. Find the description of the System.Console class in the standard .NET API documentation (MSDN Library).");
                Console.WriteLine();
                Console.WriteLine("Represents the standard input, output, and error streams for console applications. This class cannot be inherited.");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Three
        {
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("01.3. Find the description of the System.Console.WriteLine() method and its different possible parameters in the MSDN Library.");
                Console.WriteLine();
                Console.WriteLine("Writes the current line terminator to the standard output stream.");
                Console.WriteLine("WriteLine()");
                Console.WriteLine("WriteLine(Boolean)");
                Console.WriteLine("WriteLine(Char)");
                Console.WriteLine("WriteLine(Char[])");
                Console.WriteLine("WriteLine(Char[], Int32, Int32)");
                Console.WriteLine("WriteLine(Decimal)");
                Console.WriteLine("WriteLine(Double)");
                Console.WriteLine("WriteLine(Int32)");
                Console.WriteLine("WriteLine(Int64)");
                Console.WriteLine("WriteLine(Object)");
                Console.WriteLine("WriteLine(Single)");
                Console.WriteLine("WriteLine(String)");
                Console.WriteLine("WriteLine(String, Object)");
                Console.WriteLine("WriteLine(String, Object, Object)");
                Console.WriteLine("WriteLine(String, Object, Object, Object)");
                Console.WriteLine("WriteLine(String, Object, Object, Object, Object)");
                Console.WriteLine("WriteLine(String, Object[])");
                Console.WriteLine("WriteLine(UInt32)");
                Console.WriteLine("WriteLine(UInt64)");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Four
        {
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("01.4. Compile and execute the sample program from this chapter using the command prompt (the console) and Visual Studio.");
                Console.WriteLine();
                Console.WriteLine("Hello C#!");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Five
        {
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("01.5. Modify the sample program to print a different greeting, for example 'Good Day!'.");
                Console.WriteLine();
                Console.WriteLine("Good Day!");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Six
        {
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("01.6. Write a console application that prints your first and last name on the console.");
                Console.WriteLine();
                Console.WriteLine("Rob Wigmore");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }


        public static class Seven
        {
            public static void RunSEven()
            {
                Console.WriteLine();
                Console.WriteLine("01.7. Write a program that prints the following numbers on the console 1, 101, 1001, each on a new line.");
                Console.WriteLine();
                Console.WriteLine("1");
                Console.WriteLine("101");
                Console.WriteLine("1001");
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Eight //COMPLETE
        {
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("01.8. Write a program that prints on the console the current date and time.");
                Console.WriteLine();

                Console.WriteLine(DateTime.Now.ToString());

                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }


        public static class Nine //COMPLETE
        {
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("01.9. Write a program that prints the square root of 12345.");
                Console.WriteLine();

                Console.WriteLine(Math.Sqrt(12345));

                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Ten
        {
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("01.10. Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.");
                Console.WriteLine();

                int num = 2;
                Console.WriteLine(num);
                int negNum = -3;
                Console.WriteLine(negNum);

                for (int i = 0; i < 50; i++)
                {
                    num += 2;
                    Console.WriteLine(num);
                    negNum -= 2;
                    Console.WriteLine(negNum);
                }

                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Eleven
        {
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("01.11. Write a program that reads your age from the console and prints your age after 10 year");
                Console.WriteLine();

                Console.WriteLine("Please input your age");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Your age plus ten years is {0}", input + 10);
                Console.WriteLine();
                Console.WriteLine("PASS");
            }
        }

        public static class Twelve
        {
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("01.12. Describe the difference between C# and the .NET Framework.");
                Console.WriteLine();
                Console.WriteLine("C# is a programming language, .NET is the microsoft framework that it uses");
                Console.WriteLine("PASS");
            }
        }

        public static class Thirteen
        {
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("01.13. Make a list of the most popular programming languages. How are they different from C#?");
                Console.WriteLine();
                Console.WriteLine("JAVA");
                Console.WriteLine("PYTHON");
                Console.WriteLine("C++");
                Console.WriteLine("BRAINFUCK");

                Console.WriteLine("PASS");

            }
        }


        public static class Fourteen
        {
            public static void RunFourteen()
            {
                Console.WriteLine();
                Console.WriteLine("01.14. Decompile the example program from exercise 5.");
                Console.WriteLine();
                Console.WriteLine("cannot from this computer, have decomplied before.");

                Console.WriteLine("PASS");
            }
        }

    }

}


