using System;
class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();

        decimal oddSum = 0M;
        decimal oddMin = 1000000M;
        decimal oddMax = -1000000M;
        decimal evenSum = 0M;
        decimal evenMin = 1000000M;
        decimal evenMax = -1000000M;
        decimal tempo = 0M;

        if (input.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }

        string[] numbers = input.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            tempo = Math.Round(decimal.Parse(numbers[i]), 2);
            if (i % 2 == 0)
            {
                oddSum += tempo;
                if (tempo < oddMin)
                {
                    oddMin = tempo;
                }
                if (tempo > oddMax)
                {
                    oddMax = tempo;
                }
            }
            if (i % 2 == 1)
            {
                evenSum += tempo;
                if (tempo < evenMin)
                {
                    evenMin = tempo;
                }
                if (tempo > evenMax)
                {
                    evenMax = tempo;
                }
            }
        }

        if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0:G29}, OddMin={1:G29}, OddMax={2:G29}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0:G29}, OddMin={1:G29}, OddMax={2:G29}, EvenSum={3:G29}, EvenMin={4:G29}, EvenMax={5:G29}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}