using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String format

            var currentDateAndTime = string.Format("Current Date: {0}", DateTime.Now);
            Console.WriteLine(currentDateAndTime);

            //String interpolation

            var currentDateAndTime2 = $"Current Date: {DateTime.Now}";
            Console.WriteLine(currentDateAndTime2);

            //Split string

            var listOfObjects = "Ball,Phone,PC,Keyboard".Split(',');
            Console.WriteLine(listOfObjects);

            //Replace string

            var listOfNumbers = "1,2,3,4,5".Replace(",", ":");
            Console.WriteLine(listOfNumbers);

            //Contains string

            var verifyString = "Rosa Flavius-Gabriel".Contains("Flavius");
            Console.WriteLine(verifyString);

            //Compare strings

            var compareStrings = string.Compare("Flavius", "flavius", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(compareStrings);

            //Time span

            var generateTime = new TimeSpan(18, 21, 16);
            Console.WriteLine(generateTime);

            var addTime = DateTime.Now.Add(generateTime);
            Console.WriteLine(addTime);

            var utcTime = DateTime.UtcNow;
            Console.WriteLine(utcTime);

            var dateTimeOffset = DateTimeOffset.Now;
            Console.WriteLine(dateTimeOffset);

            //Culture info

            var roDate = utcTime.ToString("dddd MMMM", CultureInfo.CreateSpecificCulture("ro-RO"));
            Console.WriteLine(roDate);

        }
    }
}