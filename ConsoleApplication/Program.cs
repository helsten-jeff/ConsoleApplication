using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            // Get Name
            Console.WriteLine("Type your name, then press Enter");
            var name = Console.ReadLine();
            // Get Location
            Console.WriteLine("Type where you are from, then press Enter");
            var location = Console.ReadLine();

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            var todayDate = GetTodayDate();
            // Today's Date'
            Console.WriteLine("Today's date is: " + todayDate);

            // Days til Christmas
            var currYear = DateTime.Now.ToString("yyyy");
            var christmas = DateTime.Parse("12/25/" + currYear);

            DateTime next = christmas.AddYears(todayDate.Year - christmas.Year);

            if (next < todayDate)
                next = next.AddYears(1);

            int numDays = (next - todayDate).Days;

            Console.WriteLine("Days til christmas: " + numDays);


            // Yellow book 2.1 example

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Input a width (a number. e.g: 3) :");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Input a height: (a number. e.g: 11)");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                              woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                              glassArea + " square metres");


            Console.WriteLine("Press any key to terminate...");
            Console.ReadKey();
        }

        private static DateTime GetTodayDate()
        {
            var todayDate = DateTime.Now;
            return todayDate;
        }
    }

}