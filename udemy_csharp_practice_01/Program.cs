using System;

namespace udemy_csharp_prcatice01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicitly way
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            string firstName = "isaac";
            bool isWorking = true;

            // implicitly way
            var lastName = "iniguez";
            const double Pi = 3.14;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(lastName);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(Pi);
        }
    }
}