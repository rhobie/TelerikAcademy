using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap15_TextFiles
    {

        //01    -   COMPLETE
        //02    -   COMPLETE
        //03    -   COMPLETE
        //04    -   COMPLETE
        //05    -   started
        //06    -   
        //07    -   
        //08    -   
        //09    -   
        //10    -   
        //11    -   
        //12    -   
        //13    -   



        public static string FilePath = Directory.GetCurrentDirectory() + @"\Questions\";



        public static class One
        {
            //1.Write a program that reads a text file and prints its odd lines on the
            //console.
            //1.Use the examples discussed in this chapter.Use the using structure to
            //ensure proper closing of the input and the resulting stream.
            public static void RunOne()
            {
                //List<string> Lines = new List<string>();

                using (StreamReader reader = new StreamReader(FilePath + "QuestionOne.txt"))
                {
                    string line;
                    bool odd = false;
                    while ((line = reader.ReadLine()) != null)
                    {
                        odd = !odd;
                        //Lines.Add(line); // Add to list.
                        if (odd)
                        {
                            Console.WriteLine(line); // Write to console.
                        }

                    }
                }
            }
        }


        public static class Two
        {
            //2.Write a program that joins two text files and records the results in a
            //third file.
            //2.You will have to first read the input file line by line and save it in the
            //resulting file in overwrite mode. Then you must open the second input
            //file and save it line by line in the result file in append mode. To create a
            //StreamWriter in overwrite / use mode use the appropriate constructor
            //(find it in MSDN).
            //An alternative way is to read both files in a string with ReadToEnd() ,
            //store them in memory and save them in the resulting file.This approach
            //does not work for large files (the likes of several gigabytes).
            public static void RunTwo()
            {
                string firstString = TextfileToString((FilePath + @"\Questiontwo-First.txt"));
                string secondString = TextfileToString((FilePath + @"\Questiontwo-Second.txt"));
                string finalString = firstString + secondString;

                using (StreamWriter sw = new StreamWriter((FilePath + "QuestionTwo-Third.txt")))
                {
                    sw.Write(finalString);
                }

            }

            public static string TextfileToString(string textfileLocationAndName)
            {
                string outString = "";
                using (StreamReader reader = new StreamReader(textfileLocationAndName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        outString += line;
                    }
                }

                return outString;
            }

        }

        public static class Three
        {


            public static void RunThree()
            {
                Console.WriteLine("3.Write a program that reads the contents of a text file and inserts the " +
                                  "line numbers at the beginning of each line, then rewrites the file " +
                                  "contents. \n" +
                                  "3.Follow the examples in this chapter.Think of how you would solve the " +
                                  "task if the file were large(several gigabytes). \n\n");
                Console.WriteLine("I've changed this question so that the end file is not overwritten, " +
                                  "instead the file contents are written to the console as described.  " +
                                  "This was done so that the question can be re-run over and over. " +
                                  "Previous questions relate to writing to textfiles.\n\n");
                string textfileContents = TextfileToStringWithLineNumbers((FilePath + @"\QuestionThree.txt"));

                Console.WriteLine(textfileContents);

                Console.WriteLine("PASS");
            }


            public static string TextfileToStringWithLineNumbers(string textfileLocationAndName)
            {
                string outString = "";
                using (StreamReader reader = new StreamReader(textfileLocationAndName))
                {
                    string line;
                    int i = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string newLine = i + ". " + line + Environment.NewLine;
                        outString += newLine;
                        i++;
                    }
                }

                return outString;
            }
        }



        public static class Four
        {
            //4.Write a program that compares two text files with the same number of
            //rows line by line and prints the number of equal and the number of
            //different lines.
            //4.Follow the examples in this chapter.You will have to open both files
            //simultaneously and read them line by line in a loop. If you reach the end
            //of the(read null) file, that does not match the other’s, that means that
            //both files have different number of rows and an exception should be
            //thrown.
            public static void RunFour()
            {
                CompareTextfiles((FilePath + "Question4-Compare1.txt"), (FilePath + "Question4-Compare2.txt"));


                Console.WriteLine("CORRECT");
            }

            public static void CompareTextfiles(string filepathOne, string filepathTwo)
            {
                int sameCount = 0;
                int diffCount = 0;
                string lineOne = null;
                string lineTwo = null;
                using (StreamReader compareOne = new StreamReader(filepathOne))
                {
                    using (StreamReader compareTwo = new StreamReader(filepathTwo))
                    {
                        int lineCount = 0;
                        while ((lineOne = compareOne.ReadLine()) != null && (lineTwo = compareTwo.ReadLine()) != null)
                        {
                            lineCount++;

                            if (lineOne != null && lineOne.Equals(lineTwo))
                            {
                                Console.WriteLine("Line {0} is the same in both files", lineCount);
                                sameCount++;
                            }
                            else
                            {
                                Console.WriteLine("Line {0} is different", lineCount);
                                diffCount++;
                            }

                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("{0} lines are the same, {1} lines are different", sameCount, diffCount);
            }
        }

        public static class Five
        {
            //5.Write a program that reads a square matrix of integers from a file and
            //finds the sub-matrix with size 2 × 2 that has the maximal sum and
            //writes this sum to a separate text file. The first line of input file contains
            //the size of the recorded matrix(N).The next N lines contain N integers
            //separated by spaces.
            //Sample input file:
            //4
            //2 3 3 4
            //0 2 3 4
            //3 7 1 2
            //4 3 3 2

            //Sample output: 17.
            //5.Read the first line of the file and create a matrix with the specified size.
            //After that read the following lines, line by line and separate the numbers.
            //Then save them in the corresponding (row, column) in the matrix.Finally,
            //find the sub - matrix using two nested loops.
            public static void RunFive()
            {


                int arraySize = GetIntFromTextfile(FilePath + "Question5-SampleFile.txt");

                int[,] matrix = GetMatrixFromTextFile(FilePath + "Question5-SampleFile.txt", arraySize);


                //THIS IS WHAT I WAS DOING:
                //int maxOfSubmatrix = 0;
                //for (int i = 0; i < UPPER; i++)
                //{

                //}
                //int[] subMatrix = new int[arraySize];
                //for (int i = 0; i < arraySize; i++)
                //{
                //    for (int j = 0; j < arraySize; j++)
                //    {
                //        subMatrix[i] = matrix[i, j];
                //    }
                //}
            }


            public static int[,] GetMatrixFromTextFile(string filePath, int arraySize)
            {
                int[,] matrix = new int[arraySize, arraySize];

                using (StreamReader reader = new StreamReader(filePath))
                {
                    int rowCount = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line != arraySize.ToString()) //skip the array size at the start of the textfile
                        {
                            string[] strRow = line.Split(' ').ToArray();
                            int i = 0;
                            foreach (var stringNumToConvert in strRow)
                            {
                                Int32.TryParse(stringNumToConvert, out matrix[rowCount, i]);
                                i++;
                            }
                            i = 0;

                            rowCount++;
                        }
                    }
                }
                return matrix;
            }

            public static int GetIntFromTextfile(string filePath)
            {
                int myInt;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    Int32.TryParse(reader.ReadLine(), out myInt);
                }

                return myInt;
            }
        }


        public static class Six
        {
            //6.Write a program that reads a list of names from a text file, arranges
            //them in alphabetical order, and writes them to another file.The lines
            //are written one per row.
            //6.Write each read name in a list (List<string>), then sort it properly(look
            //for information on the method Sort()) and then print it in the result file.
            public static void RunSix()
            {

            }
        }


        public static class Seven
        {
            //7.Write a program that replaces every occurrence of the substring
            //" start " with " finish " in a text file.Can you rewrite the program to
            //replace whole words only? Does the program work for large files (e.g. 800
            //MB)?
            //7.Read the file line by line and use the methods of the class String . If you
            //load the entire file into memory, instead of reading it line by line,
            //problems when loading large files might occur.
            public static void RunSeven()
            {

            }
        }

        public static class Eight
        {
            //8.Write the previous program so that it changes only the whole words
            //(not parts of the word).
            //8. For every occurrence of “start”, check if that is the whole word or just a
            //part of it.

            public static void RunEight()
            {

            }
        }

        public static class Nine
        {
            //9.Write a program that deletes all the odd lines of a text file.
            //9. Look at the examples in this chapter.
            public static void RunNine()
            {

            }
        }

        public static class Ten
        {
            //10.Write a program that extracts from an XML file the text only(without the
            //tags).Sample input file:
            //<? xml version = "1.0" >< student >< name > Peter </ name >
            //< age > 21 </ age >< interests count = "3" >< interest >
            //       Games </ interest >< interest > C#</interest><interest>
            //Java </ interest ></ interests ></ student >
            //Sample output:
            //            Peter
            //21
            //Games
            //C#
            //Java
            //10. Read the input file character by character.When you encounter a " < ",
            //then this is a starting tag, but when you encounter a " > ", that means a
            //closing tag.All characters you encounter outside of the tags build up the
            //text that must be extracted. You can store it in StringBuilder and print
            //its contents when you encounter " < " or reach the end of the file.
            public static void RunTen()
            {

            }
        }

        public static class Eleven
        {
            //11.Write a program that deletes all words that begin with the word " test ".
            //The words will contain only the following chars: 0…9, a…z, A…Z.
            //11. Read the file line by line and replace words that start with "test" with
            //an empty string. Use Regex.Replace(…) with an appropriate regular
            //expression.Alternatively, you can search in the line the substring " test "
            //and every time you find it, get all of its neighboring letters to the left and
            //right.This way you find the word in which the string " test " is part of and
            //you can delete it if it begins with " test ".

            public static void RunEleven()
            {

            }
        }


        public static class Twelve
        {
            //12.A text file words.txt is given, containing a list of words, one per line.
            //Write a program that deletes in the file text.txt all the words that
            //occur in the other file.Catch and handle all possible exceptions.
            //12. The task is similar to the previous one.You can read the text line by
            //line and replace each of the given words with an empty string. Test
            //whether your program properly handles exceptions by simulating different
            //scenarios (e.g.no file, lack of rights for reading and writing, etc.).
            public static void RunTwelve()
            {

            }
        }


        public static class Thirteen
        {
            //13.Write a program that reads a list of words from a file called words.txt ,
            //counts how many times each of these words is found in another
            //file text.txt , and records the results in a third file – result.txt , but
            //before that, sorts them by the number of occurrences in descending
            //order.Handle all possible exceptions.
            //13. Create a hash table with keys – the words from words.txt and
            //value number of occurrences of each word ( Dictionary<string,
            //int> ). Firstly, save to the hash table that all words are found 0 times.
            //Then read the file line by line and split each line into words.Check
            //whether each obtained word can be found in the hash table, and if so,
            //add 1 to the number of occurrences.Finally, save all the words and their
            //number of occurrences in an array of type KeyValuePair<string, int>.
            //Sort the array with a suitable comparison function like so:
            //Array.Sort<KeyValuePair<string, int>>(
            //arr, (a, b) => a.Value.CompareTo(b.Value));
            public static void RunThirteen()
            {

            }
        }
    }
}

