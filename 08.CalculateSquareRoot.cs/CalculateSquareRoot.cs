using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRoot
{
    class CalculateSquareRoot
    {
        static void Main(string[] args)
        {
            /* Problem 8. Square Root
             * • Create a console application that calculates and prints the square root of the number  12345 .
             * • Find in Internet “how to calculate square root in C#”.
             */

            double Number=12345;
            double Result;
         
            Result = Math.Sqrt(Number);
            Console.WriteLine("The square root of number 12345 is = " + Result);
            Console.ReadLine();



        }
    }
}
