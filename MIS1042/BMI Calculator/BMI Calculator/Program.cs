using System;
using System.Globalization;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;

            Console.Write("Weight(kg): ");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input for weight.");
                return;
            }

            Console.Write("Height(m): ");
            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input for height.");
                return;
            }

            bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Under Weight");
                Console.WriteLine("Health Risk: Minimal");
            }

            else if (bmi >= 18.5  && bmi <= 24.9)
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Normal");
                Console.WriteLine("Health Risk: Minimal");
            }

            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Over Weight");
                Console.WriteLine("Health Risk: Increased");
            }

            else if (bmi >= 30 && bmi <= 34.9)
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Obesity ( Class 1 )");
                Console.WriteLine("Health Risk: High");
            }

            else if (bmi >= 35 && bmi <= 39.9)
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Obesity ( Class 2 )");
                Console.WriteLine("Health Risk: Very High");
            }

            else
            {
                Console.WriteLine("BMI: " + bmi);
                Console.WriteLine("Classification: Extreme Obesity");
                Console.WriteLine("Health Risk: Extremely High");
            }
        }
    }
}