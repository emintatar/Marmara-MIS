using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a program that uses if-else statements to determine if a given number is positive, negative, or zero. Display the result using Console.WriteLine(). */

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0) 
            {
                Console.WriteLine("Number is equal to zero.");
            }

            else if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }

            else
            {
                Console.WriteLine("Number is positive.");
            }
        }
    }
}