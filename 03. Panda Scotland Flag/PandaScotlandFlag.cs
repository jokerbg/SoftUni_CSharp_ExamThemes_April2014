using System;
class PandaScotlandFlag
{
    static char GetLetter(char letter)
    {
        if (letter == 'Z')
        {
            letter = 'A';
        }
        else
        {
            letter++;
        }
        return letter;
    }

    static void Main()
    {
        char letter = 'A';
        int input = Int32.Parse(Console.ReadLine());
        string[,] matrix = new string[input, input];
        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                matrix[i, j] = (i == input / 2) ? "-" : "~";
            }
        }

        for (int i = 0; i < input; i++)
        {
            for (int j = i + 1; j < input - i - 1; j++)
            {
                matrix[i, j] = "#";
                matrix[input - i - 1, j] = "#";
            }
        }

        for (int i = 0; i < input / 2; i++)
        {
            matrix[i, i] = letter.ToString();
            letter = GetLetter(letter);
            matrix[i, input - i - 1] = letter.ToString();
            letter = GetLetter(letter);
        }

        matrix[input / 2, input / 2] = letter.ToString();
        letter = GetLetter(letter);

        for (int i = input / 2 + 1; i < input; i++)
        {
            matrix[i, input - i - 1] = letter.ToString();
            letter = GetLetter(letter);
            matrix[i, i] = letter.ToString();
            letter = GetLetter(letter);
        }

        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}