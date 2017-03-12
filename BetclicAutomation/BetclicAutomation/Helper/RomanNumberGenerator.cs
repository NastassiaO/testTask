﻿using System;
using System.Linq;

namespace BetclicAutomation.Helper
{
    public class RomanNumberGenerator
    {
        public static string ToRoman(int number)
        {
            if ((number < 1) || (number > 3999))
            {
                throw new ArgumentOutOfRangeException("Number range has to be between 1 and 3999 inclusive!");
            }

            var romanNumerals = new string[][]
            {
                new string[]{"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"}, // ones
                new string[]{"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"}, // tens
                new string[]{"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}, // hundreds
                new string[]{"", "M", "MM", "MMM"} // thousands
            };

            // split integer string into array and reverse array
            var intArr = number.ToString().Reverse().ToArray();
            var len = intArr.Length;
            var romanNumeral = "";
            var i = len;

            // starting with the highest place (for 3046, it would be the thousands 
            // place, or 3), get the roman numeral representation for that place 
            // and add it to the final roman numeral string
            while (i-- > 0)
            {
                romanNumeral += romanNumerals[i][Int32.Parse(intArr[i].ToString())];
            }

            return romanNumeral;
        }
    }
}
