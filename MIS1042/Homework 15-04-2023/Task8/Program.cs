using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that demonstrates the use of nested if statements. For example, determine if a given number is divisible by 2 and 3, divisible by 2 or 3, or not divisible by either. Display the results using Console.WriteLine(). */

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                if ((number % 2 == 0) || (number % 3 == 0))
                {
                    if ((number % 2 == 0) && (number % 3 == 0))
                    {
                        Console.WriteLine("Number can be divided by 2 and 3.");
                    }

                    else if (number % 2 == 0)
                    {
                        Console.WriteLine("Number can be divided by 2.");
                    }

                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Number can be divided by 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Number can not be divided by 2 or 3 or both.");
                }
            }
            else
            {
                Console.WriteLine("Enter positive number.");
            }
        }
    }
}