using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Daniel Wilkinson";
            var location = "Mapleton, Utah";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My location is {location}");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
