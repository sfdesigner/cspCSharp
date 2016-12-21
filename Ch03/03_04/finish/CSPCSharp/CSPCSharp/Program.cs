using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing OR - ||
            if (true || false)
            {
                Console.WriteLine(true);
            }

            // Testing AND - &&
            if (true && false)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

            // Test if a number is between two numbers
            int myMaxLimit = 20;
            int myMinLimit = 5;

            int myValue = 19;

            if (myValue < myMaxLimit && myValue > myMinLimit)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

            // Test if two numbers are between two sets of numbers
            int myMaxXLimit = 5;
            int myMinXLimit = 1;
            int myMaxYLimit = 3;
            int myMinYLimit = 1;

            int myXValue = 6;
            int myYValue = 2;

            if ((myXValue < myMaxXLimit && myXValue > myMinXLimit) && (myYValue < myMaxYLimit && myYValue > myMinYLimit))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // Using NOT - !
            Boolean myBoolean = false;
            if (!myBoolean)
            {
                Console.WriteLine(true);
            }
        }
    }
}
