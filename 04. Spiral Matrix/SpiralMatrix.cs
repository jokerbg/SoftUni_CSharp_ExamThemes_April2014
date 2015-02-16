using System;
class SpiralMatrix
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToLower();

        int[,] matrix = new int[n, n];
        int[,] charMatrix = new int[n, n];

        int row = 0;
        int col = 0;
        string direction = "right";
        int moves = n * n;

        for (int i = 1; i <= moves; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                col++;
                row++;
            }
            matrix[row, col] = i;
            charMatrix[row, col] = word[(i - 1) % word.Length] - 96;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        string result = "";
        int tempo = 0, max = 0;
        for (int i = 0; i < n; i++)
        {
            tempo = 0;
            for (int j = 0; j < n; j++)
            {
                tempo += charMatrix[i, j];
            }
            if (max < tempo)
            {
                max = tempo;
                result = (i).ToString() + " - " + max * 10;
            }
        }
        Console.WriteLine(result);
    }
}