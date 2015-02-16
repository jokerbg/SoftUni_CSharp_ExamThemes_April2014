using System;
class LargestProductOfDigits
{
    static void Main()
    {
        string input = (Console.ReadLine());
        int productMax = 0;
        int tempo = 0;
        int[] matrix = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            matrix[i] = int.Parse(input[i].ToString());
        }

        for (int i = 0; i < input.Length - 5; i++)
        {
            tempo = matrix[i] * matrix[i + 1] * matrix[i + 2] * matrix[i + 3] * matrix[i + 4] * matrix[i + 5];
            if (tempo > productMax)
            {
                productMax = tempo;
            }
        }
        Console.WriteLine(productMax);
    }
}