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
            string name; // "Daniel Wilkinson";
            string location; // "Mapleton, Utah";

            Console.Write($"Please enter your name: ");
            name = Console.ReadLine();

            Console.Write($"Please enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your location is {location}");

            /* Date */
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToString("d")}");

            /* Christmas */
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"The number of days until Christmas: {numberOfDaysUntilChristmas}");

            /* Code from Textbook */
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter a width (in meters): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a height (in meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
