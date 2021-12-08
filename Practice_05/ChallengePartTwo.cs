using Practice_05.Helpers;
using System;
using System.Linq;

namespace Practice_05
{
    public class ChallengePartTwo
    {
        private readonly Writer _writer = new Writer();

        public void DivisibleByThree()
        {
            var counter = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"Numbers can be divisible by three (1 - 100): {counter} numbers");
        }

        public void InputAsker()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number please: ");
                var userInput = Console.ReadLine();
                var lcUserInput = userInput.ToLower();

                if (lcUserInput.Equals("ok") || lcUserInput.Equals(""))
                {
                    break;
                }
                else 
                {
                    var integerInput = Convert.ToInt32(lcUserInput);
                    sum += integerInput;
                    continue;
                }

            }

            Console.WriteLine($"Sum of numbers: {sum}");
        }

        public void Factorial()
        {
            var userInput = _writer.IntegerWriter("Enter a number please: ");
            Console.WriteLine("----------------");
            var factorialCalc = 1;

            for (var i = userInput; i > 0; i--)
            {
                factorialCalc *= i;
            }

            Console.WriteLine($"The factorial of {userInput} is: {factorialCalc}");
        }

        public void MortalGame()
        {
            Random random = new Random();

            var randomNumber = random.Next(1, 10);
            Console.WriteLine("Welcome to the mortal game");
            Console.WriteLine("You have to guess the myterious number, if you can guess it, I,ll let you live, otherwise You'll die here");
            Console.WriteLine("The number is between 1 and 10");
            Console.WriteLine("--------------------------------------------");

            var chances = 4;
            while (chances > 0)
            {
                var userInput = _writer.IntegerWriter("Enter your answer: ");

                if (userInput == randomNumber)
                {
                    break;
                }
                else
                {
                    chances -= 1;
                }
            }

            if (chances > 0)
            {
                Console.WriteLine("You won");
            }
            else 
            {
                Console.WriteLine("You lost.....just die jajaja");
            }
        }

        public void MaxValue()
        {
            Console.WriteLine("You need to enter a series of numbers separated by comma");
            Console.WriteLine("Enter the numbers separated by comma: ");
            var userInput = Console.ReadLine();

            var stringNumbers = userInput.Split(',');

            int[] numbers = new int[stringNumbers.Length];

            for (var i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(stringNumbers[i]);
            }

            var maxNumber = numbers.Max();

            Console.WriteLine(numbers);
        }
    }
}
