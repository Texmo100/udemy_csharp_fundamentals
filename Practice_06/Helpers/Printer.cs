using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_06.Helpers
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
            Console.WriteLine("\n");

            if (list.Count < 0)
            {
                Console.WriteLine("No likes");
            }
            else if (list.Count == 1)
            {
                Console.WriteLine($"{list[0]} likes your post");
            }
            else if (list.Count == 2)
            {
                Console.WriteLine("------------------------------------------------------------");
                for (var i = 0; i < 2; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(list[i]);
                    }
                    else
                        Console.Write($"{list[i]} and ");
                }
                Console.WriteLine(" like your post");
                Console.WriteLine("------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------");
                for (var i = 0; i < 2; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(list[i]);
                    }
                    else
                        Console.Write($"{list[i]}, ");
                }
                Console.WriteLine($" and {list.Count - 2} others like your post");
                Console.WriteLine("------------------------------------------------------------");
            }
        }

        public void IntegerListPrinter(List<int> list)
        {
            Console.WriteLine("\n");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
