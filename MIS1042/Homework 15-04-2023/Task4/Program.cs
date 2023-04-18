using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program demonstrating the use of logical operators (AND, OR, and NOT) in an if statement. Use Console.WriteLine() to output the results. */

            int num1 = 10;
            int num2 = 20;
            bool control = true;

            if ((num1 > 5 && num2 > 15) || !control)
            {
                Console.WriteLine("The first condition is true and the second condition is false.");
            }
            else
            {
                Console.WriteLine("At least one condition is false.");
            }
        }
    }
}