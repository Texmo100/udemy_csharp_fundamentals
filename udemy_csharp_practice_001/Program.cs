using System;

namespace udemy_csharp_practice_001
{
    class Program
    {
        static void Main(string[] args)
        {

            // Primitive types (Explicit declaration)
            byte superTinyNumber = 1; // 1 byte
            short tinyNumber = 2; // 2 bytes
            int normalNumber = 50; // 4 bytes
            long longNumber = 1000000; // 8 bytes
            float floatingNumber = 23.34f; // 4 bytes
            double doubleNumber = 23.45; // 8 bytes
            decimal decimalNumber = 56.24m; // 16 bytes
            bool isSomething = true; // 1 byte
            char tinyChar = 'a'; // 2 bytes

            // implicitly way
            var lastName = "iniguez";
            const double Pi = 3.14;

            Console.WriteLine(superTinyNumber);
            Console.WriteLine(tinyNumber);
            Console.WriteLine(normalNumber);
            Console.WriteLine(longNumber);
            Console.WriteLine(floatingNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(isSomething);
            Console.WriteLine(tinyChar);
            Console.WriteLine(lastName);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(Pi);
        }
    }
}