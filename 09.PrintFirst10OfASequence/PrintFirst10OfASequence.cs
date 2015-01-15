using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirst10OfASequence
{
    class PrintFirst10OfASequence
    {
        static void Main(string[] args)
        {
            /* Problem 9. Print a Sequence
             * • Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ...  
             */

            for (int i = 2 ; i < 11 ; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ,");
                }
                else
                {
                    Console.Write((i*(-1)) + " ,");
                }
            }

            Console.ReadLine();

        }
    }
}
