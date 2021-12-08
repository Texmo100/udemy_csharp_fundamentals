using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_05.Helpers
{
    public class Writer
    {
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

        public double DoubleWriter(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();

                    double doubleInput;

                    if (Double.TryParse(userInput, out doubleInput))
                    {
                        return doubleInput;
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
    }
}
