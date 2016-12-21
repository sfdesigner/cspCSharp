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
            // Creating a while loop
            int myValue = 0;

            // Loop to find numbers that are multiples of nine that are less than 100
            while (myValue < 100)
            {
                if (myValue % 9 == 0)
                {
                    Console.WriteLine(myValue);
                }

                myValue++;
            }

            // A do while loop that will run at least one time
            int myBadValue = 0;

            do
            {
                Console.WriteLine("This will run at least once.");
            } while (myBadValue != 0);
        }
    }
}
