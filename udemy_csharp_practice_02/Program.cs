using System;

namespace Practice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Explicit conversion (casting)
            int j = 1;
            byte c = (byte)j;
            Console.WriteLine(c);

            // non-compatible conversions
            var number = "1234";
            int a = Convert.ToInt32(number);
            Console.WriteLine(a);

            // handlying errors with try-catch block during a data conversion
            try
            {
                string str = "true";
                bool w = Convert.ToBoolean(str);
                Console.WriteLine(w);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}
