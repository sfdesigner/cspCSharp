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
            Console.WriteLine($"Setting the score to : {myScore}");
            DisplayScore();
            ChangeScore(100);
            ChangeScore(50);
            ChangeScore(-250);
            ChangeScore(125);
        }

        public static void ChangeScore(int scoreDelta)
        {
            Console.WriteLine($"Changing the score by: {scoreDelta}");
            myScore = myScore + scoreDelta;
            DisplayScore();
        }

        public static void DisplayScore()
        {
            Console.WriteLine($"Player score: {myScore}");
        }
    }
}
