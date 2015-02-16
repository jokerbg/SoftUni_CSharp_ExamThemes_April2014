using System;
class TextBombardment
{
    static void Main()
    {
        string text = Console.ReadLine();
        int width = Int32.Parse(Console.ReadLine());
        string[] bombs = Console.ReadLine().Split(' ');

        int height = text.Length / width + 1;
        char[,] matrix = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (width * i + j == text.Length) break;
                matrix[i, j] = text[width * i + j];
            }
        }

        //bombardment
        bool hit = false;
        for (int i = 0; i < bombs.Length; i++)
        {
            int currentBomb = int.Parse(bombs[i]);
            hit = false;
            for (int row = 0; row < height; row++)
            {
                if (matrix[row, currentBomb] == ' ' && hit) break;
                if (matrix[row, currentBomb] != ' ')
                {
                    hit = true;
                }
                matrix[row, currentBomb] = ' ';
            }
        }

        //print bombed matrix
        string tempo = "";
        for (int i = 0; i < text.Length / width + 1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (width * i + j == text.Length) break;
                tempo += matrix[i, j];
            }
        }
        Console.WriteLine(tempo);
    }
}