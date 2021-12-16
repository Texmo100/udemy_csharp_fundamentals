using Practice_06.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_06
{
    public class ArraysListsChallenge
    {
        private readonly Writer _writer = new Writer();
        private readonly Printer _printer = new Printer();

        public void FaceBookLike()
        {
            var listName = _writer.StringListWriter("Type 0 if you want to exit and display the result", 10, "Type a name please: ");
            _printer.StringListPrinter(listName);
        }

        public void ReversedName()
        {
            var name = _writer.StringWriter("Enter your name please: ");
            var reversedName = name.StringReverse();
            Console.WriteLine($"This is your name: {name} and this is your reversed name: {reversedName}");
        }

        public void SortedNumbers()
        {
            var numbers = _writer.UniqueIntegerArrayWriter(5, "Enter a unique number please: ");
            Array.Sort(numbers);
            _printer.ArrayPrinter(numbers);
        }

        public void ListOfNumbers()
        {
            var listNumber = _writer.IntegerListWriter("Type 0 if you want to exit and display the result", 100, "Enter a number plase: ");
            _printer.IntegerListPrinter(listNumber);
        }

        public void SmallestNumbers()
        {
            var numberList = _writer.NumbersSeparatedByCommaWriter
                (
                    "You need to enter a series of numbers separated by comma", 
                    "Enter the numbers separated by comma: "
                );
            var orderedNumberList = numberList.OrderList();
            _printer.IntegerListByCommaPrinter(orderedNumberList);
            _printer.ThreeSmallestNumbersPrinter(orderedNumberList);
        }
    }
}
