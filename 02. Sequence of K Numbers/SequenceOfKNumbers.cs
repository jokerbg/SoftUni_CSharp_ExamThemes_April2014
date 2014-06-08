using System;
using System.Collections.Generic;
class SequenceOfKNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] numbers = input.Split(' ');
        int k = int.Parse(Console.ReadLine());
        bool sequenceTrue = true;

        for (int i = k - 1; i < numbers.Length; i++)
        {
            sequenceTrue = true;

            for (int j = 1; j < k; j++)
            {
                if (numbers[i] != numbers[i - j])
                {
                    sequenceTrue = false; break;
                }
            }

            if (sequenceTrue)
            {
                for (int l = 0; l < k; l++)
                {
                    numbers[i - l] = "x";
                }
            }
        }

        List<string> matrix = new List<string>();

        for (int m = 0; m < numbers.Length; m++)
        {
            if (numbers[m] != "x")
            {
                matrix.Add(numbers[m]);
            }
        }

        Console.WriteLine(string.Join(" ", matrix));
    }
}