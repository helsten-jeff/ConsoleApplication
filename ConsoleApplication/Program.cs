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