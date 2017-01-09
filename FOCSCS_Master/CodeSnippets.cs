using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class CodeSnippets
    {
        //collection of useful snippets/methods ive written or come across during exercises
        //--------------------------------------------------------------------------------

        //check if even (modulo style)
        public string CheckIfEven1(int x)
        {
            if (x % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //check if even (bitwise style)
        public string CheckIfEven2(int x)
        {
            if ((x & 1) == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        public static int GetPlaceValue(int x, int place)//place = ones, tens, hundreds, thousands etc, represented by 1, 10, 100, 100 etc
        {
            //example: int 3516 -> 100s place  = 5
            return x / place % 10;
        }

        //Get int from console (including zero, ignoring everything else)
        public static int GetInt()
        {
            string s;
            int result;
            s = Console.ReadLine();
            while (!Int32.TryParse(s, out result))
            {
                if (Int32.TryParse(s, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                    s = Console.ReadLine();
                }
            }
            return result;
        }

        //swap values of two numbers without using a temp variable:
        public static void SwapInts(int a, int b, out int newA, out int newB)
        {
            //can just use this section inline, probabaly tidier and safer:
            a = a + b;
            b = a - b;
            a = a - b;
            //----------------

            newA = a;
            newB = b;
        }

        //Encoding STUFF:
        //Console.WriteLine("encoding test:");

        //string msg = "This is my secret message.";
        //string k = "7ecret..cyph3r//qu4y!"; // you can choose another key
        //StringBuilder sb = new StringBuilder();
        //for (int i = 0; i < msg.Length; i++)
        //{
        //    sb.Append((char)(msg[i] ^ k[i % k.Length]));
        //}
        //Console.WriteLine(sb.ToString());
    }
}
