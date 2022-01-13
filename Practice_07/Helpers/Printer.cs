using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_07.Helpers
{
    public class Printer
    {
        public void ArrayPrinter(int[] array)
        {
            Console.WriteLine("\n");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public void StringListPrinter(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
