using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_07.Helpers
{
    public class Writer
    {
        public string StringWriter(string msg)
        {
            while (true) 
            {
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

        public string StringHyphenWriter(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                var userInput = Console.ReadLine();

                if (userInput.IsValidStringSeparatedByHyphen())
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

        public string StringHyphenWriterWithExit(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                var userInput = Console.ReadLine();

                if (userInput.Equals(""))
                {
                    Console.WriteLine("Your input is not valid: Its empty\n");
                    Environment.Exit(0);
                }
                else if (userInput.IsValidStringSeparatedByHyphen())
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Your input is not valid: Try again please\n");
                    continue;
                }
            }
        }

        public string StringHourWriter(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                var userInput = Console.ReadLine();

                if (userInput.IsValidHourFormat())
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Invalid time: Try again please\n");
                    continue;
                }
            }
        }

        public string StringSeparatedBySpaces(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                var userInput = Console.ReadLine();

                if (userInput.IsValidStringSeparatedBySpaces())
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

    }
}
