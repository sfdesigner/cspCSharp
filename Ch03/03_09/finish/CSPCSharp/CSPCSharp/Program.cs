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
            // Creating an array
            string[] myArray = new string[] { "Doug", "Mike", "Janet", "Matt" };
            foreach (string element in myArray) Console.WriteLine(element);

            // Change an element
            myArray[0] = "Tim";
            foreach (string element in myArray) Console.WriteLine(element);

            // Creating a List
            List<String> myList = new List<string>();
            myList.Add("Rocket");
            myList.Add("Scout");
            foreach (string element in myList) Console.WriteLine(element);

            // Accessing an item in a List
            Console.WriteLine(myList[1]);

            // Getting the size of a List
            Console.WriteLine(myList.Count());

            // Inserting an element in a List
            myList.Insert(1, "Hoover");
            foreach (string element in myList) Console.WriteLine(element);

            // Removing elements from a List
            myList.Remove("Scout");
            foreach (string element in myList) Console.WriteLine(element);

            // Removing elements by index number from a List
            myList.RemoveAt(1);
            foreach (string element in myList) Console.WriteLine(element);

        }
    }
}
