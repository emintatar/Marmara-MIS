using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a program that accepts two numbers from the user, compares them using '==' and '!=' operators, and displays the results of the comparison using Console.WriteLine() */

            Console.Write("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number 1 is equal to Number 2");
            }

            else
            {
                Console.WriteLine("Number 1 is not equal to Number 2");
            }
        }
    }
}