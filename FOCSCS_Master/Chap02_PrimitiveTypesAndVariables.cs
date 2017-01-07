using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap02_PrimitiveTypesAndVariables
    {
        //1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
        //2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
        //3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
        //4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
        //5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
        //6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
        //7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
        //8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
        //9. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
        //10. Write a program to print a figure in the shape of a heart by the sign "o".
        //11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
        //12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
        //13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.

        public static class One
        {   //COMPLETE
            public static void RunOne()
            {
                Console.WriteLine();
                Console.WriteLine("02.1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.");
                Console.WriteLine();
                //sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values:
                sbyte sbyteNum1 = 52;
                byte byteNum1 = 130;
                sbyte sbyteNum2 = -115;
                int intNum1 = 4825932;
                sbyte sbyteNum3 = 97;
                short shortNum1 = -10000;
                short shortNum2 = 20000;
                byte byteNum2 = 224;
                short shortNum3 = 970;
                short shortNum4 = 700;
                string sNum2 = "000";
                sbyte sbyteNum4 = 112;
                sbyte sbyteNum5 = -44;
                int intNum2 = -1000000;
                short shortNum5 = 1990;
                long longNum1 = 123456789123456789;

                Console.WriteLine("PASS");
            }
        }

        public static class Two
        {   //COMPLETE
            public static void RunTwo()
            {
                Console.WriteLine();
                Console.WriteLine("02.2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?");
                Console.WriteLine();
                //5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
                float fNum = 3456.091124875956542151256683467f;
                double dNum = 3456.091124875956542151256683467;
                decimal decNum = 3456.091124875956542151256683467M;
                Console.WriteLine("-5.01, 34.567839023, 12.345, 8923.1234857, and 3456.091124875956542151256683467 can all be assigned to float, double and decimal, provided you use the correct sufixes for flaot and decimal and don't care about losing precision");

                Console.WriteLine("PASS");
            }
        }

        public static class Three
        {   //COMPLETE
            public static void RunThree()
            {
                Console.WriteLine();
                Console.WriteLine("02.3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.");
                Console.WriteLine();


                float a = 100 / 3;
                float b = 1 / 3 * 100;
                bool equal = Math.Abs(a - b) < 0.000001;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(equal.ToString());

                Console.WriteLine("PASS");
            }
        }

        public static class Four
        {   //COMPLETE
            public static void RunFour()
            {
                Console.WriteLine();
                Console.WriteLine("02.4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).");
                Console.WriteLine();

                int hex = 0x100;
                Console.WriteLine(hex);

                Console.WriteLine("PASS");

            }
        }

        public static class Five
        {   //COMPLETE
            public static void RunFive()
            {
                Console.WriteLine();
                Console.WriteLine("02.5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).");
                Console.WriteLine();

                char character = '\u0072';
                Console.WriteLine(character);

                Console.WriteLine("PASS");
            }

        }

        public static class Six
        {   //COMPLETE
            public static void RunSix()
            {
                Console.WriteLine();
                Console.WriteLine("02.6. Declare a variable isMale of type bool and assign a value to it depending on your gender.");
                Console.WriteLine();

                bool isMale = true;
                Console.WriteLine("is male? :: " + isMale.ToString());


                Console.WriteLine("PASS");
            }
        }
        public static class Seven
        {
            public static void RunSeven()
            {   //COMPLETE
                Console.WriteLine();
                Console.WriteLine("02.7. Declare two variables of type string with values 'Hello' and 'World'. Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.");
                Console.WriteLine();

                //7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object.
                //Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
                string hello = "Hello";
                string world = "World";

                object obg = hello + " " + world;
                Console.WriteLine(obg);

                Console.WriteLine("PASS");
            }
        }

        public static class Eight
        {
            public static void RunEight()
            {   //COMPLETE
                Console.WriteLine();
                Console.WriteLine("02.8. Declare two variables of type string and give them values 'Hello' and 'World'. "+
                "Assign the value obtained by the concatenation of the two variables of type string (do not miss the space " +
                "in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the "+
                "value of the variable of type object (you should use type casting).");
                Console.WriteLine();

                string sOne = "Hello";
                string sTwo = "World";

                object myObject = String.Concat(sOne, " ", sTwo);

                string finalString = (string)myObject;

                Console.WriteLine(finalString);
                Console.WriteLine("PASS");
            }

        }

        public static class Nine
        {
            public static void RunNine()
            {   //COMPLETE
                Console.WriteLine();
                Console.WriteLine("02.9. Declare two variables of type string and assign them a value 'The 'use' of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.");
                Console.WriteLine();

                string s = "The \"use\" of quotations causes difficulties.";
                string s2 = "The use of quotations causes difficulties.";
                Console.WriteLine(s);
                Console.WriteLine(s2);

                Console.WriteLine("PASS");
            }

        }

        public static class Ten
        {   //COMPLETE
            public static void RunTen()
            {
                Console.WriteLine();
                Console.WriteLine("02.10. Write a program to print a figure in the shape of a heart by the sign 'o'.");
                Console.WriteLine();

                Console.WriteLine("        oooooo           oooooo");
                Console.WriteLine("      oooooooooo       oooooooooo");
                Console.WriteLine("    oooooooooooooo   oooooooooooooo");
                Console.WriteLine("  ooooooooooooooooo ooooooooooooooooo");
                Console.WriteLine(" ooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine(" ooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("  ooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("   ooooooooooooooooooooooooooooooooo");
                Console.WriteLine("    ooooooooooooooooooooooooooooooo");
                Console.WriteLine("      ooooooooooooooooooooooooooo");
                Console.WriteLine("        ooooooooooooooooooooooo");
                Console.WriteLine("          ooooooooooooooooooo");
                Console.WriteLine("            ooooooooooooooo");
                Console.WriteLine("              ooooooooooo");
                Console.WriteLine("                ooooooo");
                Console.WriteLine("                  ooo");
                Console.WriteLine("                   o");


                Console.WriteLine("PASS");
            }
        }
        public static class Eleven
        {   //COMPLETE
            public static void RunEleven()
            {
                Console.WriteLine();
                Console.WriteLine("02.11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character '©'.");
                Console.WriteLine();

                Console.WriteLine("     ©");
                Console.WriteLine("    © ©");
                Console.WriteLine("   ©   ©");
                Console.WriteLine("  ©     ©");
                Console.WriteLine(" ©       ©");
                Console.WriteLine("©         ©");
                Console.WriteLine("©©©©©©©©©©©©");

                Console.WriteLine("PASS");
            }
        }
        public static class Twelve
        {   //COMPLETE
            public static void RunTwelve()
            {
                Console.WriteLine();
                Console.WriteLine("02.12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.");
                Console.WriteLine();

                string firstName = "Bob";
                string lastName = "Jones";
                int age = 34;
                char gender = 'm';
                double ID = 27560000;
                Console.WriteLine("Firstname:{0} Lastname:{1} Age:{2} Gender:{3} ID:{4}",firstName,lastName, age,gender,ID);

                Console.WriteLine("PASS");
            }
        }
        public static class Thirteen
        {   //COMPLETE
            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("02.13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.");
                Console.WriteLine();

                int a = 5;
                int b = 10;

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine("Variables were swapped without using a temp int using this:");
                Console.WriteLine("a = a + b;");
                Console.WriteLine("b = a - b;");
                Console.WriteLine("a = a - b;");
                Console.WriteLine("However I've read that its recommedend not to do it this way.");

                Console.WriteLine("int a = {0} AND int b = {1}",a,b);


                Console.WriteLine("PASS");
            }
        }
    }
}

