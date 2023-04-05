using System;

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

            string classification = "";
            string healthRisk = "";

            if (bmi < 18.5)
            {
                classification = "Under Weight";
                healthRisk = "Minimal";
            }

            else if (bmi >= 18.5  && bmi <= 24.9)
            {
                classification = "Normal";
                healthRisk = "Minimal";
            }

            else if (bmi >= 25 && bmi <= 29.9)
            {
                classification = "Over Weight";
                healthRisk = "Increased";
            }

            else if (bmi >= 30 && bmi <= 34.9)
            {
                classification = "Obesity ( Class 1 )";
                healthRisk = "High";
            }

            else if (bmi >= 35 && bmi <= 39.9)
            {
                classification = "Obesity ( Class 2 )";
                healthRisk = "Very High";
            }

            else
            {
                classification = "Extreme Obesity";
                healthRisk = "Extremely High";
            }

            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine("Classification: " + classification);
            Console.WriteLine("Health Risk: " + healthRisk);
        }
    }
}