using System;

namespace Practice_03
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 1;
            var b = 2;
            var c = 3;


            // arithmetic operators
            var sumResult = a + b;
            var divResult = (float)a / (float)b; // with float casting
            var divResult2 = (a + b * c); // with high precedence
            Console.WriteLine(sumResult);
            Console.WriteLine(divResult);
            Console.WriteLine(divResult2);

            Console.WriteLine("\n"); // line divider
            Console.WriteLine("--------------------");

            // comparison operators
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Console.WriteLine("\n"); // line divider
            Console.WriteLine("--------------------");

            // assignment operators
            // =
            // ++
            // --
            // +=
            // -=
            // *=
            // /=

            // logical operators
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b || c == a);

            Console.WriteLine("\n"); // line divider
            Console.WriteLine("--------------------");

            // bitwise operators
            // not (!) or and (&)
            Console.WriteLine(!(c > b || c == a));

            Console.WriteLine("\n"); // line divider
            Console.WriteLine("--------------------");
        }
    }
}
