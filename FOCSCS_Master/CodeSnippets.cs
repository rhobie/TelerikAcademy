using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class CodeSnippets
    {


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

        public int GetPlaceValue(int x, int place)//place = ones, tens, hundreds, thousands etc, represented by 1, 10, 100, 100 etc
        {
            //example: int 3516 -> 100s place  = 5
            return x / place % 10;
        }



    }
}
