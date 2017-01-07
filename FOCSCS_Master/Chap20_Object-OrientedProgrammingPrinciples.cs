using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    //1. We are given a school. The school has classes of students. Each class has a set of teachers. Each teacher teaches a set of courses. The students have a name and unique number in the class. Classes have a unique text identifier. Teachers have names. Courses have a name, count of classes and count of exercises. The teachers as well as the students are people. Your task is to model the classes (in terms of OOP) along with their attributes and operations define the class hierarchy and create a class diagram with Visual Studio.
    //2. Define a class Human with properties "first name" and "last name". Define the class Student inheriting Human, which has the property "mark". Define the class Worker inheriting Human with the property "wage" and "hours worked". Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked. Write the corresponding constructors and encapsulate all data in properties.
    //3. Initialize an array of 10 students and sort them by mark in ascending order. Use the interface System.IComparable<T>.
    //4. Initialize an array of 10 workers and sort them by salary in descending order.
    //5. Define an abstract class Shape with abstract method CalculateSurface() and fields width and height. Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2). Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width) with the same value (the radius) and implement the abstract method for calculating the area. Create an array of different shapes and calculate the area of each shape in another array.
    //852 Fundamentals of Computer Programming with C#
    //6. Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. All of them are animals (Animal). Animals are characterized by age, name and gender. Each animal makes a sound (use a virtual method in the Animal class). Create an array of different animals and print on the console their name, age and the corresponding sound each one makes.
    //7. Using Visual Studio generate the class diagrams of the classes from the previous task with it.
    //8. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers can be individuals or companies. All accounts have a customer, balance and interest rate (monthly based). Deposit accounts allow depositing and withdrawing of money. Loan and mortgage accounts allow only depositing. All accounts can calculate their interest for a given period (in months). In the general case, it is calculated as follows: number_of_months * interest_rate. Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company. Deposit accounts have no interest rate if their balance is positive and less than 1000. Mortgage accounts have ½ the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals. Your task is to write an object-oriented model of the bank system. You must identify the classes, interfaces, base classes and abstract actions and implement the interest calculation functionality.
    //9. Read about the Abstract Factory design pattern and implement it in C#.
    class Chap20_Object_OrientedProgrammingPrinciples
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

        public static class Seven
        {
            public static void RunSeven()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Eight
        {
            public static void RunEight()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Nine
        {
            public static void RunNine()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

    }
}
