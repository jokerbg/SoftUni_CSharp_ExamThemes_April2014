using System;
class FunWithMatrices
{
    static void Main()
    {
        double[,] matrix = new double[4, 4];
        double start = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix[j, i] = start + (i + j * 4) * step;
            }
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Game Over!") break;

            string[] entries = input.Split(' ');

            int row = int.Parse(entries[0]);
            int col = int.Parse(entries[1]);
            string command = entries[2];
            double num = double.Parse(entries[3]);

            if (command == "multiply")
            {
                matrix[row, col] *= num;
            }
            else if (command == "sum")
            {
                matrix[row, col] += num;
            }
            else
            {
                matrix[row, col] = Math.Pow(matrix[row, col], num);
            }
        }
        double maxSum = 0;
        double curSum = 0;
        string result = "";

        curSum = 0;
        for (int i = 0; i < 4; i++)
        {
            curSum += matrix[i, 3 - i];
        }
        if (maxSum <= curSum)
        {
            maxSum = curSum;
            result = "RIGHT-DIAGONAL = ";
        }

        curSum = 0;
        for (int i = 0; i < 4; i++)
        {
            curSum += matrix[i, i];
        }
        if (maxSum <= curSum)
        {
            maxSum = curSum;
            result = "LEFT-DIAGONAL = ";
        }

        for (int j = 3; j >= 0; j--)
        {
            curSum = 0;
            for (int i = 0; i < 4; i++)
            {
                curSum += matrix[i, j];
            }
            if (maxSum <= curSum)
            {
                maxSum = curSum;
                result = "COLUMN[" + j + "] = ";
            }
        }

        for (int i = 3; i >= 0; i--)
        {
            curSum = 0;
            for (int j = 0; j < 4; j++)
            {
                curSum += matrix[i, j];
            }
            if (maxSum <= curSum)
            {
                maxSum = curSum;
                result = "ROW[" + i + "] = ";
            }
        }

        Console.WriteLine("{0}{1:F2}", result, maxSum);
    }
}