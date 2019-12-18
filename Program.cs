using System;

namespace DigitSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both are equivalent.
            var bigNumber = 123456789012345678;
            var bigNumberSplit = 123_456_789_012_345_678;
            Console.WriteLine("bigNumber : {0}, bigNumberSplit : {1}", bigNumber, bigNumberSplit);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
