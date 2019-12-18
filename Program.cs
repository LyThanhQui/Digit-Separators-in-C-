using System;

namespace DigitSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both are equivalent.
            // var bigNumber = 123456789012345678;
            // var bigNumberSplit = 123_456_789_012_345_678;
            var myData1 = 1__2___3__4_______5_______6;
            var myData2 = 1__2__3_____4_5________6.79;
            Console.WriteLine("bigNumber : {0}, bigNumberSplit : {1}", myData1, 
                myData2);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
