using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPCSharp
{
    class Program
    {
        // create the score variable for the game
        public static int outsideValue = 5;

        // main function of the program
        public static void Main(String[] args)
        {
            // Output variables to the console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            Console.WriteLine($"From outside: functionValue = {functionValue}");

            MyFunction();
            MyOtherFunction();
        }

        public static void MyFunction()
        {
            // Create a variable inside of a function
            int functionValue = 10;

            // Output variables to the console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            Console.WriteLine($"From outside: functionValue = {functionValue}");
        }

        public static void MyOtherFunction()
        {
            // Output variables to the console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            Console.WriteLine($"From outside: functionValue = {functionValue}");
        }
    }
}
