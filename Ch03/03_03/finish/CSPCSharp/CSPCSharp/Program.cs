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
            Boolean knowCSharp = true;
            Console.WriteLine($"The value of knowCSharp is {knowCSharp}");

            if (knowCSharp)
            {
                Console.WriteLine("I know C#!");
            }

            if (knowCSharp) Console.WriteLine("I still know C#!");

            int myValue = 5;
            Console.WriteLine("myValue is equal to 5");
            
            if (myValue == 5)
            {
                Console.WriteLine("The condition (myValue == 5) is true");
            }

            if (myValue < 5)
            {
                Console.WriteLine("The condition (myValue < 5) is true");
            } else
            {
                Console.WriteLine("The condition (myValue < 5) is false");
            }

            if (myValue != 5)
            {
                Console.WriteLine("The condition (myValue != 5) is true");
            } else if (myValue > 5)
            {
                Console.WriteLine("The second condition (myValue > 5) is true");
            } else
            {
                Console.WriteLine("All conditions are false");
            }

            if (myValue >= 1)
            {
                Console.WriteLine("The condition (myValue >= 1) is true");
                if (myValue <= 5)
                {
                    Console.WriteLine("This condition (myValue <= 5) is true");
                }
            }
        }
    }
}
