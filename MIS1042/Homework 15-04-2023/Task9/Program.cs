using System;
using System.Linq.Expressions;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that uses a switch statement to display the name of a day based on its number (1-7). Use Console.WriteLine() to output the month's name */

            Console.Write("Option: ");
            int option = int.Parse(Console.ReadLine());
            string day = "";
            switch (option)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    break;
            }
            if (day != "")
            {
                Console.WriteLine("Day: " + day);
            }
        }
    }
}