using System;

namespace DegreeOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minRandomValue = 0;
            int maxRandomValue = 2000;
            int randomValue;

            Random random = new Random();
            randomValue = random.Next(minRandomValue, maxRandomValue);

            int degree = 2;
            int calculatedValue = 1;
            int countDegree = 0;

            while (randomValue >= calculatedValue)
            {
                Console.WriteLine($"{randomValue}>{calculatedValue}");
                countDegree++;
                calculatedValue *= degree;
            }
            
            Console.WriteLine($"{randomValue} < {calculatedValue}, где {calculatedValue} = 2 в степени {countDegree}");
        }
    }
}
