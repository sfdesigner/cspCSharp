using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPCSharp
{
    class Lynx : Cat
    {
        public Lynx()
        {
            Console.WriteLine("A new instance of Lynx created!");
        }

        public void Growl()
        {
            Console.WriteLine("Grrr!");
        }
    }
}
