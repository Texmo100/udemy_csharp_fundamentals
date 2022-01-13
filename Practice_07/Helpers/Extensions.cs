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
            var regexPattern = new Regex(@"^[a-zA-Z]+$");

            if (regexPattern.IsMatch(str))
            {
                return true;
            }

            return false;
        }

        public static bool IsValidStringSeparatedByHyphen(this string str)
        {
            var regexPattern = new Regex(@"^\d+(-\d+)+$");

            if (regexPattern.IsMatch(str))
            {
                return true;
            }

            return false;
        }

        public static bool IsConsecutive(this string numbersHyphen)
        {
            var numbersSimplified = numbersHyphen.Split("-");
            var numbersList = new List<int>();

            foreach (var number in numbersSimplified)
            {
                numbersList.Add(Convert.ToInt32(number));
            }

            var isConsecutive = true;
            var prevNumber = 0;

            for (var i = 0; i < numbersList.Count; i++)
            {
                if (i == 0)
                {
                    prevNumber = numbersList[i];
                    continue;
                }

                if (numbersList[i] != prevNumber + 1)
                {
                    if (numbersList[i] != prevNumber - 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                prevNumber = numbersList[i];
            }

            return isConsecutive;
        }

        public static bool ContainsDuplication(this string numbersHyphen)
        {
            var numbersSimplified = numbersHyphen.Split("-");
            var numbersList = new List<int>();

            foreach (var number in numbersSimplified)
            {
                numbersList.Add(Convert.ToInt32(number));
            }

            var isDuplicate = false;

            foreach (var number in numbersList)
            {
                var searchCounter = numbersList.Where(n => n == number).Count();

                if (searchCounter > 1)
                {
                    isDuplicate = true;
                }
            }

            return isDuplicate;
        }

        public static bool IsValidHourFormat(this string hour)
        {
            var regexPattern = new Regex(@"([01]?[0-9]|2[0-3]):[0-5][0-9]");

            if (regexPattern.IsMatch(hour))
            {
                return true;
            }

            return false;
        }

        public static bool IsValidStringSeparatedBySpaces(this string str)
        {
            var regexPattern = new Regex(@"^[a-zA-Z]+(\s[a-zA-Z]+)+$");

            if (regexPattern.IsMatch(str))
            {
                return true;
            }

            return false;
        }

        public static List<string> ToLowerStringList(this List<string> wordsList)
        {
            var newWordsList = new List<String>();

            foreach (var word in wordsList)
            {
                var newWord = word.ToLower();
                newWordsList.Add(newWord);
            }

            return newWordsList;
        }

        public static List<string> ToPascalStringList(this List<string> wordsList)
        {
            var newWordsList = wordsList.Select(word => (
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1).ToLower()
                )).ToList();

            return newWordsList;
        }

        public static string ConvertToPascalWord(this List<string> wordsList)
        {
            return string.Concat(wordsList);
        }

        public static int VowelsCounter(this string word) {
            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };
            var counter = 0;

            foreach(var letter in word)
            {
                counter += vowels.Where(v => v == letter).Count();
            }

            return counter;
        }
    }
}
