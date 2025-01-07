/*
 * DateTime is a stucture that is used to get info about the date and time of the System. 
 * With this, we can perform data-time related operations like finding the date, adding dates, removal dates and many more functions to extract the time stamp and other time bound operations in C#. Applications. 
 * System.DateTime is the struct used for these operations.
 * Now property is used to extract the System Date and Time. 
 * Its ToString method is overloaded to extract various parts of the date and time. 
 */
using System;
using System.Dynamic;

namespace CSharpBasics
{
    class DateTimeExample
    {
        static void Main(string[] args)
        {
            //CreatingDateTime();
            //FormatingDateTime();
            //TakingInputAsDate();
            CalculationsExample();
        }

        private static void CalculationsExample()
        {
            Console.WriteLine("Enter the date of birth as dd/MM/yyyy");
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            int age = DateTime.Now.Year - dt.Year;
            Console.WriteLine($"The Current age is {age}");

            //Calculating Exact parts of the differences using Timespan
            TimeSpan timeSpan = DateTime.Now -dt;
            Console.WriteLine("The No of days difference is {0} and the Age as per this calculation is {1}", timeSpan.TotalDays, timeSpan.TotalDays /365.25);
        }

        private static void TakingInputAsDate()
        {
            Console.WriteLine("Enter UR Date of Birth as dd/MM/yyyy");
            string input = Console.ReadLine();
            DateTime Dob = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            Console.WriteLine($"The Date of Birth is {Dob.ToLongDateString()}");
            //PS:Parse vs. ParseExact.
        }

        private static void FormatingDateTime()
        {
            //Formatting allows to extract parts of the DateTime for our computation purpose. 
            DateTime now = DateTime.Now;
            Console.WriteLine("The Long Date version: {0} and the Short Date Version: {1}", now.ToLongDateString(), now.ToShortDateString());
            Console.WriteLine("The Custom Format is {0}", now.ToString("dd/MMM/yy"));
        }

        private static void CreatingDateTime()
        {
            //Creating a DateTime Object.
            DateTime defaultTime = new DateTime();
            Console.WriteLine(defaultTime);

            //create a specific date and time:
            DateTime dt = new DateTime(2025, 1, 7);
            Console.WriteLine(dt);
            //Explore other options while creating the Date Time object.
            //extrct the local time of UR machine
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            //Current UTC Date and time. We use this for perform date-time related operations across multiple timezones. 
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"The Local Time :{now}, the UTC Time is {utc}");
        }
    }
}