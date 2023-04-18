using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that takes two integer inputs from the user and performs addition, subtraction, multiplication, and division operations on them. Display the results using Console.WriteLine(). */

            Console.Write("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + (num1 + num2));
            Console.WriteLine("Difference: " + (num1 - num2));
            Console.WriteLine("Product: " + (num1 * num2));
            Console.WriteLine("Quotient: " + (num1 / num2));
        }
    }
}