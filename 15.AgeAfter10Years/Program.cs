using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;



namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            /* Problem 15. Age after 10 Years
             * • Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
             */

            string dateString, format;
            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;
            char[] separator = new char[] { '/', '.' };
            string[] SplitYear;

            // Parse date-only value with invariant culture.
            Console.Write("Въведете рожденна дата (с формат mm/dd/yyyy) : ");
            dateString = Console.ReadLine();

            SplitYear = dateString.Split(separator);

            format = "d";
            try
            {
                result = DateTime.ParseExact(dateString, format, provider);
                Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
                if (SplitYear.Length > 2 && (DateTime.Now.Year - int.Parse(SplitYear[2]) < 150))
                {
                    int HowOldAreYou = DateTime.Now.Year - int.Parse(SplitYear[2]);
                    Console.WriteLine("You are : {0} years old!", HowOldAreYou);
                    Console.WriteLine("And after 10 years you will be {0} years old", HowOldAreYou + 10);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have entered an incorrect year");
                }
            }
            catch
            {
                Console.WriteLine("{0} is not in the correct format.", dateString);
            }

            Console.ReadLine();
           


        }
    }
}
