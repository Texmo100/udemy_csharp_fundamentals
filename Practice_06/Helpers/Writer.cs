using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_06.Helpers
{
    public class Writer
    {
        public string StringWriter(string msg)
        {
            while (true) 
            {
                Console.WriteLine("\n");
                Console.WriteLine(msg);
                var userInput = Console.ReadLine();

                if (userInput.IsValidString())
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Your input is not valid: Try again please");
                    continue;
                }
            }
        }

        public int IntegerWriter(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();
                    if (userInput.IsNumeric())
                    {
                        return Convert.ToInt32(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Input Invalid: enter a valid input please");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong during the process: {ex}");
                }

            }

        }

        public int UniqueIntegerWriter(string msg, int[] numbers)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();
                    if (userInput.IsNumeric())
                    {
                        var number =  Convert.ToInt32(userInput);
                        if (number.NumberExitsInto(numbers))
                        {
                            Console.WriteLine("This number already exists, try again");
                            continue;
                        }
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Input Invalid: enter a valid input please");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong during the process: {ex}");
                }

            }

        }

        public List<string> StringListWriter(string generalMsg, int limit, string inputMsg)
        {
            var listName = new List<string>();

            Console.WriteLine(generalMsg);

            for (var i = 0; i < limit; i++)
            {
                var userInput = StringWriter(inputMsg);
                if (userInput.Equals("0"))
                {
                    break;
                }
                listName.Add(userInput);
            }

            return listName;
        }

        public List<int> IntegerListWriter(string generalMsg, int limit, string inputMsg)
        {
            var listNumber = new List<int>();

            Console.WriteLine(generalMsg);

            for (var i = 0; i < limit; i++)
            {
                var userInput = IntegerWriter(inputMsg);
                var number = Convert.ToInt32(userInput);
                if (number == 0)
                {
                    break;
                }
                listNumber.Add(userInput);
            }

            return listNumber;
        }

        public int[] UniqueIntegerArrayWriter(int limit, string inputMsg)
        {
            var numbers = new int[limit];

            for (var i = 0; i < limit; i++)
            {
                var userInput = UniqueIntegerWriter(inputMsg, numbers);
                numbers[i] = userInput;
            }

            return numbers;
        }

        public int[] IntegerArrayWriter(int limit, string inputMsg)
        {
            var numbers = new int[limit];

            for (var i = 0; i < limit; i++)
            {
                var userInput = IntegerWriter(inputMsg);
                numbers[i] = userInput;
            }

            return numbers;
        }

        public List<int> NumbersSeparatedByCommaWriter(string firstMsg, string secondMsg)
        {
            Console.WriteLine(firstMsg);
            Console.WriteLine(secondMsg);
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput.IsValidSeparatedByComma())
                {
                    var stringNumbers = userInput.Split(',');

                    var numbers = new List<int>();

                    for (var i = 0; i < stringNumbers.Length; i++)
                    {
                        if (!stringNumbers[i].IsNumeric() || stringNumbers[i].Equals("")) continue;
                        numbers.Add(Convert.ToInt32(stringNumbers[i]));
                    }

                    return numbers;
                }
                else
                {
                    Console.WriteLine("Your input is not valid, retry again");
                    continue;
                }
            }
        }
    }
}
