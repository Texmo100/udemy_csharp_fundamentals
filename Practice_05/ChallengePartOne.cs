using Practice_05.Helpers;
using System;

namespace Practice_05
{
    public class ChallengePartOne
    {
        // Writer dependency injection
        private readonly Writer _writer = new Writer();


        public void UserInput()
        {
            var number = _writer.IntegerWriter("Give me the first number please: ");

            if (number > 0 && number <= 10)
            {
                Console.WriteLine($"this number is valid: {number} is greater than 0, and less than 10");
            }
            else
            {
                Console.WriteLine("this number is invalid");
            }
        }

        public void NumberComparison()
        {
            var userInput1 = _writer.IntegerWriter("Give me the first number please: ");
            var userInput2 = _writer.IntegerWriter("Give me the second number please: ");
            Console.WriteLine($"This is the biggest number: {Math.Max(userInput1, userInput2)}");
        }

        public void ImageRecognition()
        {
            var width = _writer.DoubleWriter("Insert the image widht: ");
            var height = _writer.DoubleWriter("Insert the image height: ");

            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("These are not a real image sizes");
            }
            else if (width < height)
            {
                Console.WriteLine("This image is portrait");
            }
            else
            {
                Console.WriteLine("This image is landscape");
            }
        }

        public void SpeedCamera()
        {
            const double speedLimit = 100.0;

            var userInput = _writer.DoubleWriter("Enter your speed please: ");

            if (userInput <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                // calculate the demerit points per 5 km/hr above the speed limit
                var demeritPointsCalc = (int)userInput - (int)speedLimit;
                var demeritPoints = demeritPointsCalc / 5;
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("Your license is suspended");
                }
                else
                {
                    Console.WriteLine($"Demerit points: {demeritPoints}");
                }

            }
        }

    }
}
