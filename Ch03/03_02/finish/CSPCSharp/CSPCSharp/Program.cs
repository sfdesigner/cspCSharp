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
            int myVariable = 5;
            Console.WriteLine($"myVariable is equal to {myVariable} and is an int");
            string  myString = myVariable.ToString();
            Console.WriteLine($"myString is equal to {myString} and is a string");
            myString += 1;
            Console.WriteLine($"myString is equal to {myString} and is a string");
            myVariable = Int16.Parse(myString) + 1;
            Console.WriteLine($"myVariable is equal to {myVariable} and is an int");
        }
    }
}
