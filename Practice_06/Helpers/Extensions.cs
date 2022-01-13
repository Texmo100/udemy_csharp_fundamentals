using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice_07.Helpers
{
    public static class Extensions
    {
        public static bool IsValidString(this string str)
        {
            var regexPattern = new Regex(@"^[a-zA-Z0-9]+$");

            if (regexPattern.IsMatch(str))
            {
                return true;
            }

            return false;
        }

        public static string StringReverse(this string str)
        {
            var lowerCaseStr = str.ToLower().Trim();
            var characters = str.ToCharArray();
            Array.Reverse(characters);
            return new String(characters);
        }

        public static bool IsNumeric(this string val)
        {
            var pattern = @"^[0-9]+$";

            if (Regex.IsMatch(val, pattern))
            {
                return true;
            }

            return false;
        }

        public static bool NumberExitsInto(this int number, int[] numbers)
        {
            var result = numbers.Where(n => n == number).Count();
            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool IsValidSeparatedByComma(this string str)
        {
            var commaFinder = str.Contains(",");
            if (commaFinder)
            {
                return true;
            }
            return false;
        }

        public static List<int> OrderList(this List<int> list)
        {
            return list.OrderBy(n => n).ToList();
        }
    }
}
