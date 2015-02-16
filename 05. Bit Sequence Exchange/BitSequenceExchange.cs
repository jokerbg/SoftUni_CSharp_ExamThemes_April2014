using System;
class BitSequenceExchange
{
    static void Main()
    {
        int[] matrix = new int[64];

        string inputStr = Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(64, '0');
        for (int j = 0; j < 64; j++)
        {
            matrix[j] = inputStr[63 - j] - '0';
        }

        for (int i = 0; i < 3; i++)
        {
            if (matrix[3 + i] != matrix[24 + i])
            {
                int tempo = matrix[3 + i];
                matrix[3 + i] = matrix[24 + i];
                matrix[24 + i] = tempo;
            }
        }

        string line = "";
        for (int j = 63; j >= 0; j--)
        {
            line += matrix[j];
        }
        Console.WriteLine(Convert.ToInt64(line, 2));
    }
}