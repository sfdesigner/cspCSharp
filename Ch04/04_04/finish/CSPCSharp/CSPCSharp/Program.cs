using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPCSharp;

namespace CSPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat pet = new Cat();
            pet.petName = "Rocket";
            pet.Speak();
            //pet.age;
            Console.WriteLine($"{pet.petName} is {pet.GetAge()} years old.");
        }
    }
}
