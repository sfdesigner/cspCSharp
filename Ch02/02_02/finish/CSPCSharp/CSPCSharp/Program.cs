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
        public static int myScore;

        // main function of the program
        static void Main(string[] args)
        {
            // Create a variable
            myScore = 1000;
            ChangeScore();
        }

        public static void ChangeScore()
        {
            myScore = myScore + 100;
            Console.WriteLine($"Player score: {myScore}");
        }
    }
}
