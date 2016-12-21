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
            string[] myArray = new string[] { "Doug", "Mike", "Janet", "Matt" };

            // Looping through an array with a for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Hello, {myArray[i]}!");
            }

            foreach (string name in myArray)
            {
                Console.WriteLine($"Good bye, {name}.");
            }
        }
    }
}
