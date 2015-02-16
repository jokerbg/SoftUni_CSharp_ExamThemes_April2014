using System;
class DoubleDowns
{
    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[,] array = new int[n, 32];
        for (int i = 0; i < n; i++)
        {
            string tempo = Convert.ToString(Int32.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
            for (int j = 0; j < 32; j++)
            {
                array[i, j] = tempo[j] - '0';
            }
        }
        //PrintMatrix(array, n);
        int rightDiag = 0;
        int leftDiag = 0;
        int vertical = 0;

        //check right-diagonal
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < 31; j++)
            {
                if (array[i, j] + array[i + 1, j + 1] == 2)
                {
                    rightDiag++;
                }
            }
        }

        //check left-diagonal
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < 32; j++)
            {
                if (array[i, j] + array[i + 1, j - 1] == 2)
                {
                    leftDiag++;
                }
            }
        }

        //check left-diagonal
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (array[i, j] + array[i + 1, j] == 2)
                {
                    vertical++;
                }
            }
        }
        Console.WriteLine(rightDiag);
        Console.WriteLine(leftDiag);
        Console.WriteLine(vertical);
    }
}