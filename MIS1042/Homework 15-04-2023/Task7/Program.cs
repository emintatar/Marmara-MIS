using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a function called 'CalculateArea' that accepts the length and width of a rectangle as arguments and returns the area. Call this function from the main method and display the result using Console.WriteLine() */

            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + CalculateArea(length, width));
        }
        
        static int CalculateArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
    }
}
