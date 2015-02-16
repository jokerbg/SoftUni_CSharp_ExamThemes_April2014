using System;
class Tetris
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);
        int figI = 0, figL = 0, figJ = 0, figO = 0, figZ = 0, figS = 0, figT = 0;

        char[,] matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string tempo = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = tempo[j];
            }
        }

        //count I
        if (rows >= 4)
        {
            for (int i = 0; i <= rows - 4; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 'o' && matrix[i + 1, j] == 'o' && matrix[i + 2, j] == 'o' && matrix[i + 3, j] == 'o')
                    {
                        figI++;
                    }
                }
            }
        }

        //count L
        if (rows >= 3)
        {
            for (int i = 0; i <= rows - 3; i++)
            {
                for (int j = 0; j <= cols - 2; j++)
                {
                    if (matrix[i, j] == 'o' && matrix[i + 1, j] == 'o' && matrix[i + 2, j] == 'o' && matrix[i + 2, j + 1] == 'o')
                    {
                        figL++;
                    }
                }
            }
        }

        //count J
        if (rows >= 3)
        {
            for (int i = 0; i <= rows - 3; i++)
            {
                for (int j = 0; j <= cols - 2; j++)
                {
                    if (matrix[i, j + 1] == 'o' && matrix[i + 1, j + 1] == 'o' && matrix[i + 2, j + 1] == 'o' && matrix[i + 2, j] == 'o')
                    {
                        figJ++;
                    }
                }
            }
        }

        //count 0
        for (int i = 0; i <= rows - 2; i++)
        {
            for (int j = 0; j <= cols - 2; j++)
            {
                if (matrix[i, j] == 'o' && matrix[i, j + 1] == 'o' && matrix[i + 1, j] == 'o' && matrix[i + 1, j + 1] == 'o')
                {
                    figO++;
                }
            }
        }

        //count Z
        if (cols >= 3)
        {
            for (int i = 0; i <= rows - 2; i++)
            {
                for (int j = 0; j <= cols - 3; j++)
                {
                    if (matrix[i, j] == 'o' && matrix[i, j + 1] == 'o' && matrix[i + 1, j + 1] == 'o' && matrix[i + 1, j + 2] == 'o')
                    {
                        figZ++;
                    }
                }
            }
        }

        //count S
        if (cols >= 3)
        {
            for (int i = 0; i <= rows - 2; i++)
            {
                for (int j = 0; j <= cols - 3; j++)
                {
                    if (matrix[i + 1, j] == 'o' && matrix[i, j + 1] == 'o' && matrix[i + 1, j + 1] == 'o' && matrix[i, j + 2] == 'o')
                    {
                        figS++;
                    }
                }
            }
        }

        //count T
        if (cols >= 3)
        {
            for (int i = 0; i <= rows - 2; i++)
            {
                for (int j = 0; j <= cols - 3; j++)
                {
                    if (matrix[i, j] == 'o' && matrix[i, j + 1] == 'o' && matrix[i + 1, j + 1] == 'o' && matrix[i, j + 2] == 'o')
                    {
                        figT++;
                    }
                }
            }
        }

        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", figI, figL, figJ, figO, figZ, figS, figT);
    }
}