using System;
using System.Runtime;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that accepts character input from the user and uses a switch statement to determine if the character is a vowel or a consonant. Display the result using Console.WriteLine(). */

            Console.Write("Character: ");
            char chr = char.Parse(Console.ReadLine());

            switch (Char.ToLower(chr))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The character is a vowel.");
                    break;
                default:
                    Console.WriteLine("The character is a consonant.");
                    break;
            }
        }
    }
}