﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPCSharp
{
    class Cat
    {
        public string petName;

        public Cat()
        {
            Console.WriteLine("A new instance of Cat created!");
        }

        public void Speak()
        {
            Console.WriteLine($"{petName} says, \"Meow!\"");
        }
    }
}
