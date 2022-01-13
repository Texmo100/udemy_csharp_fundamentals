using Practice_07.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_07
{
    public class StringsChallenge
    {
        private readonly Writer _writer = new Writer();

        public void NumbersHyphen()
        {
            var numbersHyphen = _writer.StringHyphenWriter("Enter the numbers separated by hyphen please: ");

            if (numbersHyphen.IsConsecutive())
            {
                Console.WriteLine("The list is consecutive");
            }
            else
            {
                Console.WriteLine("The list is not consecutive");
            }
        }

        public void DuplicatedNumbersHyphen()
        {
            var numbersHyphen = _writer.StringHyphenWriterWithExit("Enter the numbers separated by hyphen please: ");
            if (numbersHyphen.ContainsDuplication())
            {
                Console.WriteLine("The list contains duplication");
            }
            else
            {
                Console.WriteLine("The list does not contain duplication");
            }
        }

        public void GoodHour()
        {
            var hourInput = _writer.StringHourWriter("Enter the 24 hour format please: ");
            Console.WriteLine($"OK: {hourInput}");
        }

        public void PascalWords()
        {
            var wordsSeparatedBySpaces = _writer.StringSeparatedBySpaces("Enter the words separated by spaces please: ");
            var wordsList = wordsSeparatedBySpaces.Split(" ").ToList();
            var lowerWordsList = wordsList.ToLowerStringList();
            var pascalWordsList = lowerWordsList.ToPascalStringList();
            var pascalWord = pascalWordsList.ConvertToPascalWord();

            Console.WriteLine("\n" + pascalWord);
        }

        public void LotOfVowels()
        {
            var word = _writer.StringWriter("Enter a word please: ");
            var vowelCounter = word.VowelsCounter();
            if (vowelCounter > 0)
            {
                Console.WriteLine("This word contains vowels");
                Console.WriteLine($"This is the number of vowels inside the word: {vowelCounter}");

            }
            else
            {
                Console.WriteLine("This word doesnt contain vowels");
            }
        }
    }
}
