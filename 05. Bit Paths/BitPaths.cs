using System;
class BitPaths
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[,] matrix = new int[8, 4];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix[i, j] = 0;
            }
        }

        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            int index = 0;
            for (int j = 0; j < 8; j++)
            {
                matrix[j, index + Int32.Parse((arr[j]))] = matrix[j, index + Int32.Parse((arr[j]))] == 0 ? 1 : 0;
                index = index + Int32.Parse((arr[j]));
            }
        }
        //PrintMatrix(matrix);
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            string current = "";
            for (int j = 0; j < 4; j++)
            {
                current += matrix[i, j];
            }
            sum += Convert.ToInt32(current, 2);
        }

        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine(Convert.ToString(sum, 16).ToUpper());
    }
}